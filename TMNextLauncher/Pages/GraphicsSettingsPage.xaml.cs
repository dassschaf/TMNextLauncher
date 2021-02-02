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
            MaxRefreshrateTextbox.Text = settingsController.settings.Display.RefreshRate.ToString();

            // Customize:
            CustomizeSwitch.IsOn = settingsController.settings.Display.Customize;

            // Antialiasing:
            switch (settingsController.settings.Display.Antialiasing)
            {
                case "none":
                    AntialiasingCombo.SelectedItem = "off";
                    break;

                case "_2_samples":
                    AntialiasingCombo.SelectedItem = "MSAA 2x";
                    break;

                case "_4_samples":
                    AntialiasingCombo.SelectedItem = "MSAA 4x";
                    break;


                case "_6_samples":
                    AntialiasingCombo.SelectedItem = "MSAA 6x";
                    break;


                case "_8_samples":
                    AntialiasingCombo.SelectedItem = "MSAA 8x";
                    break;

                case "16_samples":
                    AntialiasingCombo.SelectedItem = "MSAA 16x";
                    break;
            }

            // Deferred AA:
            switch (settingsController.settings.Display.DeferredAA)
            {
                case "none":
                    DeferredAntialiasingCombo.SelectedItem = "off";
                    break;

                case "_taa":
                    DeferredAntialiasingCombo.SelectedItem = "TAA";
                    break;

                case "_fxaa":
                    DeferredAntialiasingCombo.SelectedItem = "FXAA";
                    break;
            }

            // Shader Quality:
            switch (settingsController.settings.Display.ShaderQuality)
            {
                case "very_fast":
                    ShaderCombo.SelectedItem = "Very fast";
                    break;

                case "fast":
                    ShaderCombo.SelectedItem = "Fast";
                    break;

                case "nice":
                    ShaderCombo.SelectedItem = "Nice";
                    break;

                case "very_nice":
                    ShaderCombo.SelectedItem = "Very nice";
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

        private void DeferredAntialiasingCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = e.AddedItems[0].ToString();

            if (selectedItem == "off")
                settingsController.settings.Display.DeferredAA = "none";

            if (selectedItem == "TAA")
                settingsController.settings.Display.DeferredAA = "_taa";

            if (selectedItem == "FXAA")
                settingsController.settings.Display.DeferredAA = "_fxaa";
        }

        private void ShaderCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = e.AddedItems[0].ToString();

            if (selected == "Very fast")
                settingsController.settings.Display.ShaderQuality = "very_fast";

            if (selected == "Fast")
                settingsController.settings.Display.ShaderQuality = "fast";

            if (selected == "Nice")
                settingsController.settings.Display.ShaderQuality = "nice";

            if (selected == "Very nice")
                settingsController.settings.Display.ShaderQuality = "very_nice";
        }

        private void TextureQCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextureFilterCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MaxRefreshrateTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
