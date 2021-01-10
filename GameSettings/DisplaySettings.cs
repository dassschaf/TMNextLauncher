using System;
using System.Collections.Generic;
using System.Text;

namespace GameSettings
{
    class DisplaySettings
    {

        string DisplayMode;

        string ScreenSizeFS;

        string ScreenSizeWin;

        uint RefreshRate;

        string DisplaySync;

        string TripleBuffer;

        bool Customize = true;

        string Preset = "none";

        string Antialiasing;

        string DeferredAA;

        ShaderQuality ShaderQuality;

        TexturesQuality TexturesQuality;

        string FilterAnisoQ;

        string ZClip;

        string ZClipAuto;

        uint ZClipBlock;

        GeometryQuality GeometryQuality;

    }
}
