using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TMNextLauncherWpf.Pages
{
    /// <summary>
    /// Interaktionslogik für GraphicsSettingsPage.xaml
    /// </summary>
    public partial class GraphicsSettingsPage : Page
    {
        public SettingsController settings;

        Dictionary<string, string> jsonWordPairs = new Dictionary<string, string>
        {
            ["Windowed"] = "windowed",
            ["Windowed Fullscreen"] = "windowfull",
            ["Fullscreen"] = "fullscreen",
            ["Very fast"] = "very_fast",
            ["Fast"] = "fast",
            ["Nice"] = "nice",
            ["Very nice"] = "very_nice",
            ["Very low"] = "very_low",
            ["Low"] = "low",
            ["Medium"] = "medium",
            ["High"] = "high",
            ["None"] = "none",
            ["Off"] = "off",
            ["On"] = "on",
            ["High in Replays"] = "highinreplay",
            ["FXAA"] = "_fxaa",
            ["TXAA"] = "_txaa",
            ["Anisotropic x4"] = "anisotropic__4x",
            ["Anisotropic x8"] = "anisotropic__8x",
            ["Anisotropic x16"] = "anisotropic__16x",
            ["Trilinear"] = "trilinear",
            ["Bilinear"] = "bilinear",
            ["2x MSAA"] = "_2_samples",
            ["4x MSAA"] = "_4_samples",
            ["6x MSAA"] = "_6_samples",
            ["8x MSAA"] = "_8_samples",
            ["16x MSAA"] = "_16_samples"
        };

        public GraphicsSettingsPage()
        {
            InitializeComponent();
        }

        public void displaySettings(SettingsController set)
        {
            this.settings = set;
        }

        /// <summary>
        /// Translates a setting from its json value in the settings to the appropriate "normal" name
        /// </summary>
        /// <param name="s">Json value</param>
        /// <returns></returns>
        private string dejsonify(string s)
        {
            if (jsonWordPairs.ContainsValue(s))
            {
                // since our values are unique, we can just get the first fitting result
                return jsonWordPairs.FirstOrDefault(x => x.Value == s).Key;
            }

            else
            {
                // we're in trouble.
                return "";
            }
        }

        /// <summary>
        /// Returns the json-valid string for the translated setting
        /// </summary>
        /// <param name="s">Setting</param>
        /// <returns></returns>
        private string jsonify(string s)
        {
            if (jsonWordPairs.ContainsKey(s))
            {
                // get value
                return jsonWordPairs[s];
            }

            else
            {
                // we're in trouble, again.
                return "";
            }
        }

        /// <summary>
        /// Returns the json-valid string for the translated setting
        /// </summary>
        /// <param name="b">On-Off-Boolean</param>
        /// <returns></returns>
        private string jsonify(bool b)
        {
            if (b) return "on";
            else   return "off";

        }

        private void DisplayModeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
