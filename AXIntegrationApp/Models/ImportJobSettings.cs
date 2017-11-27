using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AXIntegrationApp.Models.Enums;

namespace AXIntegrationApp.Models
{
    class ImportJobSettings
    {
        /// <summary>
        /// Gets the input dir.
        /// </summary>
        /// <value>
        /// The input dir.
        /// </value>
        public string InputDir { get; private set; }

        /// <summary>
        /// Gets the upload success dir.
        /// </summary>
        /// <value>
        /// The upload success dir.
        /// </value>
        public string UploadSuccessDir { get; private set; }

        /// <summary>
        /// Gets the upload errors dir.
        /// </summary>
        /// <value>
        /// The upload errors dir.
        /// </value>
        public string UploadErrorsDir { get; private set; }

        /// <summary>
        /// Gets the company.
        /// </summary>
        /// <value>
        /// The company.
        /// </value>
        public string Company { get; private set; }

        /// <summary>
        /// Gets the status file extension.
        /// </summary>
        /// <value>
        /// The status file extension.
        /// </value>
        public string StatusFileExtension { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [execution job present].
        /// </summary>
        /// <value>
        /// <c>true</c> if [execution job present]; otherwise, <c>false</c>.
        /// </value>
        public bool ExecutionJobPresent { get; private set; }

        /// <summary>
        /// Gets the search pattern.
        /// </summary>
        /// <value>
        /// The search pattern.
        /// </value>
        public string SearchPattern { get; private set; }

        /// <summary>
        /// Gets the order by.
        /// </summary>
        /// <value>
        /// The order by.
        /// </value>
        public OrderByOptions OrderBy { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [reverse order].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [reverse order]; otherwise, <c>false</c>.
        /// </value>
        public bool ReverseOrder { get; private set; }

        /// <summary>
        /// Gets data project.
        /// </summary>
        /// <value>
        /// Data project.
        /// </value>
        public string DataProject { get; private set; }

        /// <summary>
        /// Gets a value indicating whether to overwrite existing data project.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [overwrite]; otherwise, <c>false</c>.
        /// </value>
        public bool OverwriteDataProject { get; private set; }

        /// <summary>
        /// Gets a value indicating whether to execute import.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [execute]; otherwise, <c>false</c>.
        /// </value>
        public bool ExecuteImport { get; private set; }

        /// <summary>
        /// Package template location.
        /// </summary>
        /// <value>
        /// Package template location.
        /// </value>
        public string PackageTemplate { get; private set; }
    }
}
