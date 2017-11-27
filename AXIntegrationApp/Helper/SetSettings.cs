using AXIntegrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXIntegrationApp.Helper
{
    class SetSettings
    {
        public static Settings InitSettings()
        {
            Settings _settings = new Settings();

            _settings.InstansName = "D365";
            _settings.AosUri = "https://co365devfa1ca833247d43e0devaos.cloudax.dynamics.com";
            _settings.AzureAuthEndpoint = "https://login.microsoftonline.com";
            _settings.AadTenant = "3bc062e4-ac9d-4c17-b4dd-3aad637ff1ac";

            _settings.AadClientId = new Guid("a3fa856b-7470-44d0-95be-c7b16e6bdb3d");
            _settings.AadClientSecret = "XQsBrBDIO2wziZuUKHyj/VRCNXZFn653GdyPS/XZbH0=";

            return _settings;
        }
    }
}
