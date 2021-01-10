﻿using System;
using System.Text.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace GameSettings
{
    public class DisplaySettings : ISettings
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

        [JsonPropertyName("Decals_3D (TextureDecals)")]
        bool Decals3D;

        [JsonPropertyName("Decals_2D (TextureDecals)")]
        bool Decals2D;

        string FxBloomHdr;

        string FxMotionBlur;

        float FxMotionBlurIntens;

        string FxBlur;

        [JsonPropertyName("LM SizeMax")]
        string LightmapSizeMax;

        [JsonPropertyName("LM Quality")]
        string LightmapQuality;

        [JsonPropertyName("LM QUltra")]
        bool LightmapQUltra;

        [JsonPropertyName("LM iLight")]
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

        public ISettings DefaultSettings()
        {
            throw new NotImplementedException();
        }

        public ISettings SettingsFromJson(string json)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the json string representing this DisplaySettings object
        /// </summary>
        /// <returns></returns>
        public string JsonExport()
        {

        }
    }
}
