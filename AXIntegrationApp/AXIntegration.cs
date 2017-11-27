using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using System;
using AXIntegrationApp.Models;
using AXIntegrationApp.Helper;
using AXIntegrationApp.Controller;
using System.IO;
using static AXIntegrationApp.Models.Enums;

namespace AXIntegrationApp
{
    public static class AXIntegration
    {
        public static Settings settings;
        public static ExportJobSettings exportSettings;
        public static HttpClientHelper httpClientHelper;
        public static String responseStr;
        public static bool hasConntact = false;
        public static bool export = true;

        public static HttpClientHelper _httpClientHelper { get; set; }
        public static MessageHelper _messageHelper { get; set; }

        [FunctionName("AXIntegration")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            _messageHelper = new MessageHelper();
            log.Info("C# HTTP trigger function processed a request.");

            log.Info("Starting...");

            settings = new Settings();
            settings = SetSettings.InitSettings();

            log.Info("AOS Url: " + settings.AosUri + ", Tenant: " + settings.AadTenant);


            responseStr = "OK";
            settings.UseServiceAuthentication = true;

            hasConntact = new ValidateConnection().Validate(settings, log);

            log.Info("Connection :" +  hasConntact);

            if (hasConntact && export)
            {
                //exportSettings = settings as ExportJobSettings;
                settings.DataProject = "USMF Customer download2";
                settings.Company = "USMF";
                //exportSettings.DownloadSuccessDir = "C:\\";
                //exportSettings.DownloadSuccessDir = "C:\\error";

                
                

                using (_httpClientHelper = new HttpClientHelper(settings))
                {
                    log.Info("Start export");
                    var executionId = _messageHelper.CreateExecutionId(settings.DataProject);
                    log.Info("Execution id: " + executionId);
                    var responseExportToPackage = await _httpClientHelper.ExportToPackage(settings.DataProject, executionId, executionId, settings.Company, log);

                    log.Info("Expoty to package done: " + responseExportToPackage.IsSuccessStatusCode);
                    /*
                    if (!responseExportToPackage.IsSuccessStatusCode)
                        throw new Exception(string.Format("Job_0_Download_failure_1", responseExportToPackage.StatusCode));


                    var executionStatus = "";
                    const int RETRIES = 10;
                    var i = 0;
                    do
                    {
                        executionStatus = await _httpClientHelper.GetExecutionSummaryStatus(executionId);
                        if (executionStatus == "NotRun" || executionStatus == "Executing")
                        {
                            System.Threading.Thread.Sleep(exportSettings.Interval);
                        }
                        i++;
                        log.Info(string.Format("Job_0_Checking_if_export_is_completed_Try_1", i));
                    }
                    while ((executionStatus == "NotRun" || executionStatus == "Executing") && i <= RETRIES);

                    if (executionStatus == "Succeeded" || executionStatus == "PartiallySucceeded")
                    {
                        Uri packageUrl = await _httpClientHelper.GetExportedPackageUrl(executionId);

                        var response = await _httpClientHelper.GetRequestAsync(new UriBuilder(packageUrl).Uri, false);
                        if (!response.IsSuccessStatusCode)
                            throw new Exception(string.Format("Job_0_Download_failure_1", string.Format($"Status: {response.StatusCode}. Message: {response.Content}")));

                        using (Stream downloadedStream = await response.Content.ReadAsStreamAsync())
                        {
                            var fileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss-ffff}.zip";
                            var successPath = Path.Combine(exportSettings.DownloadSuccessDir, fileName);
                            var dataMessage = new DataMessage()
                            {
                                FullPath = successPath,
                                Name = fileName,
                                MessageStatus = MessageStatus.Succeeded
                            };
                            //FileOperationsHelper.Create(downloadedStream, dataMessage.FullPath);

                            StreamReader sr = new StreamReader(downloadedStream);
                            string text = sr.ReadToEnd();

                            responseStr = responseStr + text;

                            if (exportSettings.UnzipPackage)
                                FileOperationsHelper.UnzipPackage(dataMessage.FullPath, exportSettings.DeletePackage, exportSettings.AddTimestamp);
                        }
                    }
                    else if (executionStatus == "Unknown" || executionStatus == "Failed" || executionStatus == "Canceled")
                    {
                        throw new Exception(string.Format("Export_execution_failed_for_job_0_Status_1", executionStatus));
                    }
                    else
                    {
                        log.Error(string.Format("Job_0_Execution_status_1_Execution_Id_2", executionStatus, executionId));
                    }
                    */

                }
            }



            return req.CreateResponse(HttpStatusCode.OK, responseStr);
        }

        
    }
}
