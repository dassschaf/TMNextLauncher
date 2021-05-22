using System;
using System.Collections.Generic;
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

        public GraphicsSettingsPage()
        {
            InitializeComponent();
        }

        public void displaySettings(SettingsController set)
        {
            this.settings = set;

            DisplayModeCombobox.SelectedItem = 
        }

        /// <summary>
        /// Translates a setting from its json value in the settings to the appropriate "normal" name
        /// </summary>
        /// <param name="s">Json value</param>
        /// <returns></returns>
        private string dejsonify(string s)
        {
        }

        /// <summary>
        /// Returns the json-valid string for the translated setting
        /// </summary>
        /// <param name="s">Setting</param>
        /// <returns></returns>
        private string jsonify(string s)
        {
            if (s == "Windowed") return "windowed";
            if (s == "Windowed Fullscreen") return "windowfull";
            if (s == "Fullscreen") return "fullscreen";
            if (s == "Very fast") return "very_fast";
            if (s == "Fast") return "fast";
            if (s == "Nice") return "nice";
            if (s == "Very nice") return "very_nice";
            if (s == "Very low") return "very_low";
            if (s == "Low") return "low";
            if (s == "Medium") return "medium";
            if (s == "High") return "high";
            if (s == "None") return "none";
            if (s == "Off") return "off";
            if (s == "On") return "on";
            if (s == "High in Replays") return "highinreplay";
            if (s == "FXAA") return "_fxaa";
            if (s == "TXAA") return "_txaa";
            if (s == "Anisotropic x4") return "anisotropic__4x";
            if (s == "Anisotropic x8") return "anisotropic__8x";
            if (s == "Anisotropic x16") return "anisotropic__16x";
            if (s == "Trilinear") return "trilinear";
            if (s == "Bilinear") return "bilinear";
            if (s == "2x MSAA") return "_2_samples";
            if (s == "4x MSAA") return "_4_samples";
            if (s == "6x MSAA") return "_6_samples";
            if (s == "8x MSAA") return "_8_samples";
            if (s == "16x MSAA") return "_16_samples";

            // nothing matches; return ""
            return "";
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
