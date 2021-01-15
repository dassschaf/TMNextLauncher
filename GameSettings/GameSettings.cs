using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GameSettings
{
    public class GameSettings
    {

        public string GamePackQuality;

        public bool IsSafeMode;

        public DisplaySettings Display;

        public DisplaySettings DisplaySafe;

        public bool NetworkUseProxy;

        public string NetworkProxyUrl;

        public uint NetworkServerPort = 2350;

        public uint NetworkP2PServerPort = 3450;

        public uint NetworkClientPort = 0;

        public string NetworkSpeed;

        public uint NetworkCustomUpload;

        public uint NetworkCustomDownload;

        public bool NetworkForceUseLocalAddress;

        public string NetworkForceServerAddress;

        public uint NetworkServerBroadcastLength;

        public bool NetworkTestInternetConnection;

        public bool NetworkUseNatUPnP;

        public string NetworkLastUsedMSAddress;

        public string NetworkLastUsedMSPath;

        public bool FileTransferEnableUpload;

        public bool FileTransferEnableDownload;

        public bool EnableLocators;

        public bool AutoUpdateFromLocatorAtInternetConnection;

        public bool AutoUpdateFromLocator;

        public string AutoUpdateLocatorDBUrl;

        public bool FileTransferEnableAvatarDownload;

        public bool FileTransferEnableAvatarUpload;

        public bool FileTransferEnableAvatarLocators;

        public bool FileTransferEnableMapDownload;

        public bool FileTransferEnableMapUpload;

        public bool FileTransferEnableMapLocators;

        public bool FileTransferEnableMapModDownload;

        public bool FileTransferEnableMapModUpload;

        public bool FileTransferEnableMapModLocators;

        public bool FileTransferEnableMapSkinDownload;

        public bool FileTransferEnableMapSkinUpload;

        public bool FileTransferEnableMapSkinLocators;

        public bool FileTransferEnableTagDownload;

        public bool FileTransferEnableTagUpload;

        public bool FileTransferEnableTagLocators;

        public bool FileTransferEnableVehicleSkinDownload;

        public bool FileTransferEnableVehicleSkinUpload;

        public bool FileTransferEnableVehicleSkinLocators;

        public bool FileTransferEnableUnknownTypeDownload;

        public bool FileTransferEnableUnknownTypeUpload;

        public bool FileTransferEnableUnknownTypeLocators;

        public bool IsIgnorePlayerSkins;

        public bool IsSkipRollingDemo;

        public bool GameProfileEnableMulti;

        public string GameProfileName;

        public uint PlayerInfoDisplaySize;

        public string PlayerInfoDisplayType;

        public bool DisableReplayRecording;

        public string TmCarQuality;

        public string TmCarParticlesQuality;

        public string PlayerShadow;

        public string PlayerOcclusion;

        public string TmOpponents;

        public uint TmMaxOpponents;

        public string TmBackgroundQuality;

        public uint SmMaxPlayerResimStepPerFrame;

        public bool AudioEnabled;

        public string AudioDevice_Oal;

        public bool AudioMuteWhenAppUnfocused;

        public float AudioSoundVolume;

        public float AudioMusicVolume;

        public string AudioGlobalQuality;

        public bool AudioAllowEFX;

        public bool AudioAllowHRTF;

        public bool AudioDisableDoppler;

        public bool InputsAlternateMethod;

        public bool InputsCaptureKeyboard;

        public bool InputsFreezeUnusedAxes;

        public bool InputsEnableRumble;

        public string Advertising_Enabled;

        public float Advertising_TunningCoef;

        public bool Advertising_DisabledByUser;

        public bool EnableCrashLogUpload;

        public string BlackListUrl;

        public string BadWordListUrl;

        public string AntiCheatServerUrl;

        public string DesiredLanguageId;

        public static GameSettings SettingsFromJson(string json)
        {
            return JsonSerializer.Deserialize<GameSettings>(json, new JsonSerializerOptions { IncludeFields = true });
        }

        public string JsonExport()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { IncludeFields = true, WriteIndented = true,  });
        }
    }
}
