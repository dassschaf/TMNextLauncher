using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace TMNextLauncher.Pages
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class GraphicsSettingsPage : Page
    {
        SettingsController settingsController;

        public GraphicsSettingsPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.settingsController = e.Parameter as SettingsController;

            // make UI show the current settings
            settingsToUi();
        }

        void settingsToUi()
        {
            // if it's borked don't read settings to the UI
            if (this.settingsController == null) { return; }


            // Display mode:
            switch (settingsController.settings.Display.DisplayMode) {
                case "fullscreen":
                    DisplaymodeCombo.SelectedItem = "Fullscreen";
                    break;

                case "windowedfull":
                    DisplaymodeCombo.SelectedItem = "Windowed Fullscreen";
                    break;

                case "windowed":
                    DisplaymodeCombo.SelectedItem = "Windowed";
                    break;
            }

            // Refresh rate:
            RefreshrateTextbox.Text = settingsController.settings.Display.RefreshRate.ToString();

            // Customize:
            CustomizeSwitch.IsOn = settingsController.settings.Display.Customize;
        }

        private void DisplaymodeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems[0].ToString() == "Fullscreen")
                settingsController.settings.Display.DisplayMode = "fullscreen";
            if (e.AddedItems[0].ToString() == "Windowed Fullscreen")
                settingsController.settings.Display.DisplayMode = "windowedfull";
            if (e.AddedItems[0].ToString() == "Windowed")
                settingsController.settings.Display.DisplayMode = "windowed";
        }

        private async void RefreshrateTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = sender as TextBox;
            uint rate;

            if (uint.TryParse(tb.Text, out rate))
            {
                // if it's integer-y
                settingsController.settings.Display.RefreshRate = rate;
            }
            else
            {
                tb.Text = settingsController.settings.Display.RefreshRate.ToString();

                MessageDialog d = new MessageDialog("You must enter an integer number for your refresh rate.");
                await d.ShowAsync();
            }
        }

        private void CustomizeSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            var sw = sender as ToggleSwitch;

            if (sw != null)
            {
                if (sw.IsOn)
                {
                    settingsController.settings.Display.Customize = true;
                }
                
                else
                {
                    settingsController.settings.Display.Customize = false;
                }
            }
        }
    }
}
