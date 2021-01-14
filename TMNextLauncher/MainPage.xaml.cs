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

using GameSettings;
using Windows.Storage;
using TMNextLauncher.Pages;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace TMNextLauncher
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        GameSettings.GameSettings settings;

        public MainPage()
        {
            this.InitializeComponent();

            this.settings = GameSettings.GameSettings.SettingsFromJson(File.ReadAllText("ms-appx:///../Assets/testSettings.json"));
        }

        private void MainNavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            // get nav options right
            FrameNavigationOptions navOptions = new FrameNavigationOptions();
            navOptions.TransitionInfoOverride = args.RecommendedNavigationTransitionInfo;

            // launch item clicked
            if (args.InvokedItemContainer.Name == "ItemLaunch")
            {
                ContentFrame.Content = "launch";

                // TODO: start TM2020
            }

            // settings item clicked
            if (args.InvokedItemContainer.Name == "ItemGameSettings")
            {
                // navigate to settings page
                ContentFrame.NavigateToType(typeof(SettingsPage), null, navOptions);
            }

            // exit item clicked
            if (args.InvokedItemContainer.Name == "ItemExit")
            {
                Application.Current.Exit();
            }

            if (args.IsSettingsInvoked)
            {
                ContentFrame.NavigateToType(typeof(AppSettingsPage), null, navOptions);
            }
        }
    }
}
