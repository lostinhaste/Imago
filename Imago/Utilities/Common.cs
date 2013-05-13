using System;
using System.Web;
using System.Xml;
namespace Imago.Utilities
{
    public class Common
    {
        /// <summary>
        /// Extracts a value from the settings.config (location pulled from Constants) based on the tag name
        /// </summary>
        public static string GetSetting(string settingName)
        {
            var setting = String.Empty;
            try
            {
                var settingsLocation = HttpContext.Current.Server.MapPath(Bean.Constants.SettingsFileLocation);
                var xDoc = new XmlDocument();
                xDoc.Load(settingsLocation);

                setting = xDoc.GetElementsByTagName(settingName)[0].FirstChild.Value;
            }
            catch (Exception e)
            {
                Logger.Error(String.Format("Unable to read setting '{0}', type: {1}", settingName, e.GetType()));
                Logger.Error(e.Message);
                Logger.Error(e.StackTrace);
            }

            return setting;
        }
    }
}