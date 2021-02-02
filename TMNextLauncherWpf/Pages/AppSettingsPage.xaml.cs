using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaktionslogik für AppSettingsPage.xaml
    /// </summary>
    public partial class AppSettingsPage : Page
    {
        public AppSettingsPage()
        {
            InitializeComponent();

            if (Properties.Settings.Default.GameExePath != "")
            {
                // update UI
                GamePathLabel.Content = Properties.Settings.Default.GameExePath;
            }

            if (Properties.Settings.Default.SettingsJsonPath != "")
            {
                // update UI
                SettingsPathLabel.Content = Properties.Settings.Default.SettingsJsonPath;
            }
        }

        private void GamePathButton_Click(object sender, RoutedEventArgs e)
        {
            // set up Dialog
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Trackmania.exe|Trackmania.exe";
            dialog.Multiselect = false;
            dialog.Title = "Select game executable.";

            // show dialog
            if (dialog.ShowDialog() == true)
            {
                string path = dialog.FileName;

                // update settings
                Properties.Settings.Default.GameExePath = path;
                Properties.Settings.Default.Save();

                // update UI
                GamePathLabel.Content = path;
            }
        }

        private void SettingsPathButton_Click(object sender, RoutedEventArgs e)
        {
            // set up Dialog
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Default.json|Default.json";
            dialog.Multiselect = false;
            dialog.Title = "Select game settings file.";

            // show dialog
            if (dialog.ShowDialog() == true)
            {

                string path = dialog.FileName;

                // update settings
                Properties.Settings.Default.SettingsJsonPath = path;
                Properties.Settings.Default.Save();

                // update UI
                SettingsPathLabel.Content = path;
            }

        }
    }
}
