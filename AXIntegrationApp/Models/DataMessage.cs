using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AXIntegrationApp.Models.Enums;

namespace AXIntegrationApp.Models
{
    public class DataMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataMessage"/> class.
        /// </summary>
        public DataMessage()
        {
        }

        /// <summary>
        /// Initiate new dataMessage object based on existing one
        /// </summary>
        /// <param name="dataMessage"></param>
        public DataMessage(DataMessage dataMessage)
        {
            Name = dataMessage.Name;
            FullPath = dataMessage.FullPath;
            MessageId = dataMessage.MessageId;
            MessageStatus = dataMessage.MessageStatus;
            DataJobState = dataMessage.DataJobState;
            CorrelationId = dataMessage.CorrelationId;
            PopReceipt = dataMessage.PopReceipt;
            DownloadLocation = dataMessage.DownloadLocation;
        }

        /// <summary>
        /// Name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Full path of the message
        /// </summary>
        /// <value>
        /// The full path.
        /// </value>
        public string FullPath { get; set; }

        /// <summary>
        /// Id of the message in data job queue
        /// </summary>
        /// <value>
        /// The message identifier.
        /// </value>
        public string MessageId { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        /// <value>
        /// The message status.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageStatus MessageStatus { get; set; }

        /// <summary>
        /// Data job state
        /// </summary>
        /// <value>
        /// The state of the data job.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public DataJobState DataJobState { get; set; }

        /// <summary>
        /// Gets or sets the correlation identifier.
        /// </summary>
        /// <value>
        /// The correlation identifier.
        /// </value>
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the pop receipt.
        /// </summary>
        /// <value>
        /// The pop receipt.
        /// </value>
        public string PopReceipt { get; set; }

        /// <summary>
        /// Gets or sets the download location.
        /// </summary>
        /// <value>
        /// The download location.
        /// </value>
        public string DownloadLocation { get; set; }
    }
}
