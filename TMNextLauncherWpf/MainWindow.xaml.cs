using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using TMNextLauncherWpf.Pages;

namespace TMNextLauncherWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SettingsController settings;

        public MainWindow()
        {
            InitializeComponent();

            // check if paths are set
            if (Properties.Settings.Default.GameExePath == "" || Properties.Settings.Default.SettingsJsonPath == "")
                ContentFrame.Navigate(new AppSettingsPage());

            this.settings = new SettingsController();
        }

        private void AppSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            // navigate to app settings button
            ContentFrame.Navigate(new AppSettingsPage());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            // shut down app
            App.Current.Shutdown();
        }

        private void LaunchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GraphicsSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new GraphicsSettingsPage());
        }

        private void AudioSettingsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NetworkSettingsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadSetingsButton_Click(object sender, RoutedEventArgs e)
        {
            settings.ReadSettingsFromFile();

            // if path is set, settings will load.
            // Debug.WriteLine("Settings loaded: " + settings.settings.JsonExport());
        }

        private void SaveSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            settings.SaveSettingsToFile();
        }
    }
}
