using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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
            switch (settingsController.settings.Display.DisplayMode)
            {
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

            // Antialiasing:
            switch (settingsController.settings.Display.Antialiasing)
            {
                case "none":

                case "_2_samples":



                case "_4_samples":



                case "_6_samples":



                case "_8_samples":


                case "16_samples":

                    break;
            }
        }

        private void DisplaymodeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = e.AddedItems[0].ToString();

            if (selected == "Fullscreen")
                settingsController.settings.Display.DisplayMode = "fullscreen";
            if (selected == "Windowed Fullscreen")
                settingsController.settings.Display.DisplayMode = "windowedfull";
            if (selected == "Windowed")
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

        private void AntialiasingCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = e.AddedItems[0].ToString();

            if (selected == "off")
                settingsController.settings.Display.Antialiasing = "none";

            if (selected == "MSAA x2")
                settingsController.settings.Display.Antialiasing = "_2_samples";

            if (selected == "MSAA x4")
                settingsController.settings.Display.Antialiasing = "_4_samples";

            if (selected == "MSAA x6")
                settingsController.settings.Display.Antialiasing = "_6_samples";

            if (selected == "MSAA x8")
                settingsController.settings.Display.Antialiasing = "_8_samples";

            if (selected == "MSAA x16")
                settingsController.settings.Display.Antialiasing = "_16_samples";

        }
    }
}
