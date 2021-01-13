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
    /// Graphics settings subpage of the settings page. Upon navigation to, it requires the GameSettings object as parsed from JSON to be passed to as parameter.
    /// </summary>
    public sealed partial class GraphicsSettingsPage : Page
    {
        GameSettings.GameSettings settings;

        public GraphicsSettingsPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.settings = (GameSettings.GameSettings)e.Parameter;
        }
    }
}
