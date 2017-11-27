using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXIntegrationApp.Models
{
    public class ExportJobSettings : Settings
    {
        /// <summary>
        /// Gets the download success dir.
        /// </summary>
        /// <value>
        /// The download success dir.
        /// </value>
        public string DownloadSuccessDir { get; set; }

        /// <summary>
        /// Gets the download errors dir.
        /// </summary>
        /// <value>
        /// The download errors dir.
        /// </value>
        public string DownloadErrorsDir { get; set; }

        /// <summary>
        /// Gets a value indicating whether [unzip package].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [unzip package]; otherwise, <c>false</c>.
        /// </value>
        public bool UnzipPackage { get; set; }

        /// <summary>
        /// Gets a value indicating whether [add timestamp].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [add timestamp]; otherwise, <c>false</c>.
        /// </value>
        public bool AddTimestamp { get; set; }

        /// <summary>
        /// Gets a value indicating whether [delete package].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [delete package]; otherwise, <c>false</c>.
        /// </value>
        public bool DeletePackage { get; set; }

        /// <summary>
        /// Gets data project.
        /// </summary>
        /// <value>
        /// Data project.
        /// </value>
        public string DataProject { get; set; }

        /// <summary>
        /// Gets legal entity id.
        /// </summary>
        /// <value>
        /// Legal entity id.
        /// </value>
        public string Company { get; set; }
    }
}
