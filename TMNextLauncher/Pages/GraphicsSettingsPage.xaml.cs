using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    }
}
