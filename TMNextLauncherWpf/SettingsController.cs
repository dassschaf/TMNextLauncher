using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.IO;

namespace TMNextLauncherWpf
{
    public class SettingsController
    {
        public GameSettings.GameSettings settings;

        public void ReadSettingsFromFile()
        {
            if (Properties.Settings.Default.SettingsJsonPath == "")
            {
                MessageBox.Show("No settings file had been set yet.");
                return;
            }

            // grab json
            string json = File.ReadAllText(Properties.Settings.Default.SettingsJsonPath);

            // parse
            this.settings = GameSettings.GameSettings.SettingsFromJson(json);            
        }

        public void SaveSettingsToFile()
        {
            if (Properties.Settings.Default.SettingsJsonPath == "")
            {
                MessageBox.Show("No settings file had been set yet.");
                return;
            }

            if (this.settings == null)
            {
                MessageBox.Show("There's nothing to save yet.");
                return;
            }

            // get json
            string json = settings.JsonExport();

            // save
            File.WriteAllText(Properties.Settings.Default.SettingsJsonPath, json);
        }

    }
}
