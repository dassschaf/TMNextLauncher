using System;
using System.Text.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace GameSettings
{
    public class DisplaySettings : ISettings
    {

        /// d3d11
        string RenderingApi = "d3d11";

        /// Your GPU name
        string Adapter;

        DisplayMode DisplayMode;

        string ScreenSizeFS;

        string ScreenSizeWin;

        bool SteroByDefault;

        bool StereoAdvanced;

        uint RefreshRate;

        string DisplaySync;

        string TripleBuffer;

        bool Customize = true;

        string Preset = "none";

        string Antialiasing;

        DeferredAA DeferredAA;

        ShaderQuality ShaderQuality;

        TexturesQuality TexturesQuality;

        TextureFiltering FilterAnisoQ;

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

        BloomHdr FxBloomHdr;

        OnOff FxMotionBlur;

        float FxMotionBlurIntens;

        OnOff FxBlur;

        [JsonPropertyName("LM SizeMax")]
        string LightmapSizeMax;

        [JsonPropertyName("LM Quality")]
        string LightmapQuality;

        [JsonPropertyName("LM QUltra")]
        bool LightmapQUltra;

        [JsonPropertyName("LM iLight")]
        bool LightmapILight;

        string ScreenShotExt = "jpg";

        ShadowQuality Shadows;

        GpuSync GpuSync0;

        GpuSync GpuSync1;

        GpuSync GpuSync2;

        GpuSync GpuSync3;

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
            var parsedObject = JsonDocument.Parse(json);

            var newSettings = new DisplaySettings();



            return newSettings;
        }

        /// <summary>
        /// Returns the json string representing this DisplaySettings object
        /// </summary>
        /// <returns></returns>
        public string JsonExport()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters =
                {
                    new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                }
            };

            return JsonSerializer.Serialize(this, options);
        }
    }
}
