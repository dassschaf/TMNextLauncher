using System.Text.Json.Serialization;

namespace GameSettings
{
    [System.Serializable]
    public class DisplaySettings
    {
        /// d3d11
        public string RenderingApi = "d3d11";

        /// Your GPU name
        public string Adapter;

        public string DisplayMode;

        public string ScreenSizeFS;

        public string ScreenSizeWin;

        public bool StereoByDefault;

        public bool StereoAdvanced;

        public uint RefreshRate;

        public string DisplaySync;

        public string TripleBuffer;

        public bool Customize = true;

        public string Preset = "none";

        public string Antialiasing;

        public string DeferredAA;

        public string ShaderQuality;

        public string TexturesQuality;

        public string FilterAnisoQ;

        public string ZClip;

        public string ZClipAuto;

        public uint ZClipNbBlock;

        public string GeometryQuality;

        public float GeomLodScaleZ;

        public string WaterReflect;

        public bool WaterGeomStadium;

        public string VehicleReflect;

        public uint VehicleReflectMaxCount;

        [JsonPropertyName("Decals_3D (TextureDecals)")]
        public bool Decals3D;

        [JsonPropertyName("Decals_2D (TextureDecals)")]
        public bool Decals2D;

        public string FxBloomHdr;

        public string FxMotionBlur;

        public float FxMotionBlurIntens;

        public string FxBlur;

        [JsonPropertyName("LM SizeMax")]
        public string LightmapSizeMax;

        [JsonPropertyName("LM Quality")]
        public string LightmapQuality;

        [JsonPropertyName("LM QUltra")]
        public bool LightmapQUltra;

        [JsonPropertyName("LM iLight")]
        public bool LightmapILight;

        public string ScreenShotExt = "jpg";

        public string Shadows;

        public string GpuSync0;

        public string GpuSync1;

        public string GpuSync2;

        public string GpuSync3;

        public uint GpuSyncTimeOut;

        public uint MaxFps;

        public bool EmulateCursorGDI;

        public bool OptimPartDynaGeom;

        public bool DisableZBufferRange;

        public bool DisableWindowedAntiAlias;

        public bool DisableHdrCubeRenderMipMap;

        public bool EnableFullscreenGDI;

        public string LightFromMap;

        public bool EnableCheckLags;

        public float AgpUseFactor;

        public float ParticleMaxGpuLoadMs;

        public bool AsyncRender;

        public bool MultiThread = true;

        public uint ThreadCountMax;

        public bool Automatic_Enabled;

        public uint Automatic_MinFps;
    }
}
