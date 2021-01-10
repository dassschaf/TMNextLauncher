using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        float GeomLodScaleZ;

        string WaterReflect;

        bool WaterGeomStadium;

        string VehicleReflect;

        uint VehicleReflectMaxCount;

        // Decals_3D (TextureDecals)
        bool Decals3D;

        // Decals_2D (TextureDecals)
        bool Decals2D;

        string FxBloomHdr;

        string FxMotionBlur;

        float FxMotionBlurIntens;

        string FxBlur;



    }
}
