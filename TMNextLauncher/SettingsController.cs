using System;
using System.Collections.Generic;
using Windows.Storage;
using Windows.Storage.AccessCache;
using Windows.Storage.Pickers;
using Windows.Storage.Provider;
using Windows.UI.Popups;

namespace TMNextLauncher
{
    class SettingsController
    {
        public GameSettings.GameSettings settings;

        public SettingsController()
        {
            // lol
        }

        public async void ReadGameSettings()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            if (localSettings.Values["SettingsPath"] != null)
            {
                var accessToken = localSettings.Values["SettingsPath"] as string;

                var file = await StorageApplicationPermissions.FutureAccessList.GetFileAsync(accessToken);

                string settingsJson = await FileIO.ReadTextAsync(file);

                // parse and store the object
                settings = GameSettings.GameSettings.SettingsFromJson(settingsJson);

                // notify user
                MessageDialog dialog = new MessageDialog("Successfully read the settings.");
                await dialog.ShowAsync();
            }
            else
            {
                // notify user
                MessageDialog dialog = new MessageDialog("Make sure you have set a path for your settings file in order to load it.");
                await dialog.ShowAsync();
            }
        }

        public async void SaveGameSettings()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            if (localSettings.Values["SettingsPath"] != null && settings != null)
            {
                var accessToken = localSettings.Values["SettingsPath"] as string;

                var file = await StorageApplicationPermissions.FutureAccessList.GetFileAsync(accessToken);

                await FileIO.WriteTextAsync(file, this.settings.JsonExport());

                // notify user
                MessageDialog dialog = new MessageDialog("Successfully saved the settings.");
                await dialog.ShowAsync();
            }
            else
            {
                // notify user
                MessageDialog dialog = new MessageDialog("Make sure you have set a path for your settings and have loaded them prior to trying to save them.");
                await dialog.ShowAsync();
            }
        }

        public async void SaveGameSettingsElsewhere()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            if (settings != null)
            {
                // get json ready
                string settingsJson = settings.JsonExport();

                // prepare picker
                var picker = new FileSavePicker();
                picker.FileTypeChoices.Add(".json", new List<String>() { ".json" });
                picker.SuggestedFileName = "Default";
                picker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;

                // do saving work
                StorageFile file = await picker.PickSaveFileAsync();

                if (file != null)
                {
                    // prevent updates of the file until we're finished
                    CachedFileManager.DeferUpdates(file);

                    // update file
                    await FileIO.WriteTextAsync(file, settingsJson);

                    // check status
                    FileUpdateStatus status = await CachedFileManager.CompleteUpdatesAsync(file);
                    if (status == FileUpdateStatus.Complete)
                    {
                        MessageDialog dialog = new MessageDialog("Successfully saved.");
                        await dialog.ShowAsync();
                    }
                    else // something went wrong?!
                    {
                        MessageDialog dialog = new MessageDialog("An error occoured during saving.");
                        await dialog.ShowAsync();
                    }
                }
            }
            else
            {
                MessageDialog dialog = new MessageDialog("You need to load your settions prior to saving them.");
                await dialog.ShowAsync();
            }
        }
    }
}
