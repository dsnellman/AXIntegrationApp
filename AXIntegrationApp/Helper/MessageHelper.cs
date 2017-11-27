using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXIntegrationApp.Helper
{
    public class MessageHelper
    {
        public string CreateExecutionId(string dataProject)
        {
            return $"{dataProject}-{DateTime.Now:yyyy-MM-dd_HH-mm-ss}-{Guid.NewGuid().ToString()}";
        }
    }
}
