using System;
using System.Configuration;
using System.Globalization;

namespace BidOne.TechincalTask.Web.Models
{
    public static class AppSettings
    {

        public static string FilePath
        {
            get
            {
                return Setting<string>("FilePath");
            }
        }

        private static T Setting<T>(string name)
        {
            string value = ConfigurationManager.AppSettings[name];

            if (value == null)
            {
                throw new Exception(String.Format("Could not find setting '{0}',", name));
            }

            return (T)Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture);
        }
    }
}