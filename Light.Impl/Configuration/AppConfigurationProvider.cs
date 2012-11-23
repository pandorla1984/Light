using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Light.Core;

namespace Light.Impl.Configuration
{
    public class AppConfigurationProvider : IConfigProvider
    {
        public string[] AllKeys { get; set; }

        public void Init()
        {
            try
            {
                AllKeys = ConfigurationManager.AppSettings.AllKeys;
            }
            catch (ConfigurationErrorsException ex)
            {                
                throw;
            }
        }

        
    }
}
