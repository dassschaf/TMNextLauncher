using System;
using System.Collections.Generic;
using System.Text;

namespace GameSettings
{
    public interface ISettings
    {

        string JsonExport();

        ISettings DefaultSettings();

        ISettings SettingsFromJson(string json);
    }
}
