using AXIntegrationApp.Helper;
using AXIntegrationApp.Models;
using Microsoft.Azure.WebJobs.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AXIntegrationApp.Controller
{
    class ValidateConnection
    {

        public bool Validate(Settings _settings, TraceWriter log)
        {
            bool hasConntact = false;
            HttpClientHelper httpClientHelper = new HttpClientHelper(_settings);

            try
            {
                var response = Task.Run(async () =>
                {
                    var result = await httpClientHelper.GetRequestAsync(new Uri(_settings.AosUri));
                    return result;
                });
                response.Wait();
                //responseStr = "AAD_authentication_was_successful";
                log.Info("AAD_authentication_was_successful" + Environment.NewLine);

                if (response.Result.StatusCode == HttpStatusCode.OK)
                {
                    //responseStr = responseStr + " | " + "D365FO_instance_seems_to_be_up_and_running";
                    log.Info("D365FO_instance_seems_to_be_up_and_running" + Environment.NewLine);
                    hasConntact = true;
                }
                else
                {
                    //responseStr = responseStr + " | " + $"{"Warning_HTTP_response_status_for_D365FO_instance_is"} {response.Result.StatusCode.ToString()}";
                    log.Info($"{"Warning_HTTP_response_status_for_D365FO_instance_is"} {response.Result.StatusCode.ToString()} {response.Result.ReasonPhrase}." + Environment.NewLine);
                    hasConntact = false;
                }
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                {
                    //responseStr = responseStr + " | " + ex.Message;
                    log.Info(ex.Message + Environment.NewLine);
                }
                var inner = ex;
                while (inner.InnerException != null)
                {
                    var innerMessage = inner.InnerException?.Message;
                    if (!string.IsNullOrEmpty(innerMessage))
                        log.Info(innerMessage + Environment.NewLine);
                    inner = inner.InnerException;
                }
            }

            return hasConntact;
        }

    }
}
