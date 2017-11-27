using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXIntegrationApp.Models
{
    public class Settings
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string InstansName { get; set; }
        /// <summary>
        /// Gets or sets the aos URI.
        /// </summary>
        /// <value>
        /// The aos URI.
        /// </value>
        public string AosUri { get; set; }

        /// <summary>
        /// Gets or sets the azure authentication endpoint.
        /// </summary>
        /// <value>
        /// The azure authentication endpoint.
        /// </value>
        public string AzureAuthEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the aad tenant.
        /// </summary>
        /// <value>
        /// The aad tenant.
        /// </value>
        public string AadTenant { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [use service authentication].
        /// </summary>
        /// <value>
        /// <c>true</c> if [use service authentication]; otherwise, <c>false</c>.
        /// </value>
        public bool UseServiceAuthentication { get; set; }

        /// <summary>
        /// Gets or sets the aad client identifier.
        /// </summary>
        /// <value>
        /// The aad client identifier.
        /// </value>
        public Guid AadClientId { get; set; }

        /// <summary>
        /// Gets or sets the aad client secret.
        /// </summary>
        /// <value>
        /// The aad client secret.
        /// </value>
        public string AadClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the user password.
        /// </summary>
        /// <value>
        /// The user password.
        /// </value>
        public string UserPassword { get; set; }

        /// <summary>
        /// Gets or sets execution interval.
        /// </summary>
        /// <value>
        /// The execution interval.
        /// </value>
        public int Interval { get; private set; }

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
