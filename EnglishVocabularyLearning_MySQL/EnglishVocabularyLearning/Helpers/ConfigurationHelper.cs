using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabularyLearning
{
	public class ConfigurationHelper
	{
        private static Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

        public static string readConfiguration(string configName)
		{
            KeyValueConfigurationCollection settings = config.AppSettings.Settings;

			if (!settings.AllKeys.Contains(configName))
			{
				return string.Empty;
			}

			return settings[configName].Value;
		}

		public static void writeConfiguration(string configName, string configValue)
		{
            KeyValueConfigurationCollection settings = config.AppSettings.Settings;

			if (!settings.AllKeys.Contains(configName))
			{
				settings.Add(configName, configValue);
			}
			else
			{
				settings[configName].Value = configValue;
			}

            config.Save();
        }
	}
}
