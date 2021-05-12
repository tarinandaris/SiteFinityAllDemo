using System.Configuration;

namespace SitefinityWebApp.Helper
{
    public class ConfigurationHelper
    {
        public static string ClientBaseAddress
        {
            get
            {
                return ConfigurationManager.AppSettings["ClientBaseAddress"].ToString();
            }
        }
    }
}