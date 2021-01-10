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

        // LM SizeMax
        string LightmapSizeMax;

        // LM Quality
        string LightmapQuality;

        // LM QUltra
        bool LightmapQUltra;

        // LM iLight
        bool LightmapILight;

        string ScreenShotExt = "jpg";

        string Shadows;

        string GpuSync0;

        string GpuSync1;

        string GpuSync2;

        string GpuSync3;

        uint GpuSyncTimeout;

        uint MaxFps;

        bool EmulateCursorGDI;

        bool OptimPartDynaGeometry;

        bool DisableZBufferRange;

        bool DisableWindowedAntiAlias;

        bool EnableFullscreenGDI;

        string LightFromMap;

        bool EnableCheckLags;

        float AgpUseFactor;

        float ParticleMaxGpuLoadMs;

        bool AsyncRender;

        bool MultiThread = true;

        uint ThreadCountMax;

        bool AutomaticEnabled;

        uint AutomaticMinFps;

    }
}
