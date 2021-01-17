using System;
using TMNextLauncher.Pages;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace TMNextLauncher
{


    /// <summary>
    /// Main page containing the main navigation and main content frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        SettingsController settingsController;

        public MainPage()
        {
            this.InitializeComponent();

            this.settingsController = new SettingsController();

            // set home screen layout:
            ContentTitle.Text = "Home";
        }

        private void MainNavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            // get nav options right
            FrameNavigationOptions navOptions = new FrameNavigationOptions();
            navOptions.TransitionInfoOverride = args.RecommendedNavigationTransitionInfo;

            if (args.IsSettingsInvoked)
            {
                ContentTitle.Text = "App settings";
                ContentFrame.NavigateToType(typeof(AppSettingsPage), null, navOptions);
            }

            if (args.InvokedItemContainer.Name == "ItemHome")
            {
                ContentFrame.NavigateToType(typeof(BlankPage), null, navOptions);
                ContentTitle.Text = "Home";
            }

            if (args.InvokedItemContainer.Name == "ItemGraphics")
            {
                ContentFrame.NavigateToType(typeof(GraphicsSettingsPage), this.settingsController, navOptions);
                ContentTitle.Text = "Graphics settings";
            }

            if (args.InvokedItemContainer.Name == "ItemNetwork")
            {
                ContentFrame.NavigateToType(typeof(BlankPage), null, navOptions);
                ContentTitle.Text = "Network settings";
            }

            if (args.InvokedItemContainer.Name == "ItemDownloads")
            {
                ContentFrame.NavigateToType(typeof(BlankPage), null, navOptions);
                ContentTitle.Text = "File transfer settings";
            }

            if (args.InvokedItemContainer.Name == "ItemAudio")
            {
                ContentFrame.NavigateToType(typeof(BlankPage), null, navOptions);
                ContentTitle.Text = "Audio settings";
            }
        }

        private void CommandButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private async void CommandButtonLaunch_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            if (localSettings.Values["GameExePath"] != null)
            {

            }
            else
            {
                MessageDialog dialog = new MessageDialog("You need to set the path to the game's executable file in order to start TrackMania from here.");
                await dialog.ShowAsync();
            }

            // TODO: Launch TM
        }

        private async void CommandButtonSave_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            if (localSettings.Values["SettingsPath"] != null && this.settingsController != null)
            {
                this.settingsController.SaveGameSettings();
            }
            else
            {
                MessageDialog dialog = new MessageDialog("You need to set the path to the game's configuration file in your Documents folder to save settings.");
                await dialog.ShowAsync();
            }
        }

        private async void CommandButtonLoad_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            if (localSettings.Values["SettingsPath"] != null)
            {
                this.settingsController.ReadGameSettings();
            }
            else
            {
                MessageDialog dialog = new MessageDialog("You need to set the path to the game's configuration file in your Documents folder to read settings.");
                await dialog.ShowAsync();
            }
        }

        private async void MainNavView_Loaded(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            if ((localSettings.Values["SettingsPath"] == null) || (localSettings.Values["GameExePath"] == null))
            {
                MessageDialog dialog = new MessageDialog("You have to set a path to your settings file and your game executable in order to make use of this program's features. Open the settings panel at the bottom to do so.");
                await dialog.ShowAsync();

                ContentTitle.Text = "App settings";
                ContentFrame.NavigateToType(typeof(AppSettingsPage), null, null);
            }
        }
    }
}
