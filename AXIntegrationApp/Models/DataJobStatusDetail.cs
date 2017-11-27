using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXIntegrationApp.Models
{
    public class DataJobStatusDetail
    {
        /// <summary>
        /// The data job status
        /// </summary>
        public DataJobStatus DataJobStatus;

        /// <summary>
        /// The execution log
        /// </summary>
        public string ExecutionLog;

        /// <summary>
        /// Gets or sets the execution detail.
        /// </summary>
        /// <value>
        /// The execution detail.
        /// </value>
        public List<EntityExecutionStatus> ExecutionDetail { get; set; }
    }
}
