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

using TMNextLauncher;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.Storage.AccessCache;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace TMNextLauncher.Pages
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class AppSettingsPage : Page
    {

        SettingsController settingsController;

        public AppSettingsPage()
        {
            this.InitializeComponent();

            this.settingsController = new SettingsController();

            // access settings storage
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            // update displayed paths if the app had been opened before
            if (localSettings.Values["SettingsPath"] != null)
                SettingsPathTextBlock.Text = localSettings.Values["SettingsPath"] as string;
         
            if (localSettings.Values["GameExePath"] != null)
                GamePathTextblock.Text = localSettings.Values["GameExePath"] as string;
        }

        private async void SettingsPathUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var picker = new FileOpenPicker();

            picker.ViewMode = PickerViewMode.List;
            picker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            picker.FileTypeFilter.Add(".json");

            StorageFile file = await picker.PickSingleFileAsync();

            if (file != null)
            {
                string filePath = file.Path;

                // save access token
                ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

                var token = StorageApplicationPermissions.FutureAccessList.Add(file);
                localSettings.Values["SettingsPath"] = token;

                // update UI
                SettingsPathTextBlock.Text = filePath;
            } 
            else
            {
                MessageDialog dialog = new MessageDialog("An error has occoured when trying to open the file. Maybe tell dassschaf to fix this shit.", "Error.");
                await dialog.ShowAsync();
            }
        }

        private async void GamePathUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var picker = new FileOpenPicker();

            picker.ViewMode = PickerViewMode.List;
            picker.SuggestedStartLocation = PickerLocationId.ComputerFolder;
            picker.FileTypeFilter.Add(".exe");

            StorageFile file = await picker.PickSingleFileAsync();

            if (file != null)
            {
                string filePath = file.Path;

                // save path
                ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

                var token = StorageApplicationPermissions.FutureAccessList.Add(file);
                localSettings.Values["GameExePath"] = token;

                // update UI
                GamePathTextblock.Text = filePath;
            }
            else
            {
                MessageDialog dialog = new MessageDialog("An error has occoured when trying to open the file. Maybe tell dassschaf to fix this shit.", "Error.");
                await dialog.ShowAsync();
            }
        }

        private void PathResetButton_Click(object sender, RoutedEventArgs e)
        {
            // reset path
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values["GameExePath"] = null;
            localSettings.Values["SettingsPath"] = null;
        }
    }
}
