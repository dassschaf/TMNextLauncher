using System;

namespace GameSettings
{
    public class GameSettings
    {

        string GamePackQuality;

        bool IsSafeMode;

        DisplaySettings Display;

        DisplaySettings DisplaySafe;

        bool NetworkUseProxy;

        string NetworkProxyUrl;

        uint NetworkServerPort = 2350;

        uint NetworkP2PServerPort = 3450;

        uint NetworkClientPort = 0;

        string NetworkSpeed;

        uint NetworkCustomUpload;

        uint NetworkCustomDownload;

        bool NetworkForceUseLocalAddress;

        string NetworkForceServerAddress;

        uint NetworkServerBroadcastLength;

        bool NetworkTestInternetConnection;

        bool NetworkUseNatUPnP;

        string NetworkLastUsedMSAddress;

        string NetworkLastUsedMSPath;

        bool FileTransferEnableUpload;

        bool FileTransferEnableDownload;

        bool EnableLocators;

        bool AutoUpdateFromLocatorAtInternetConnection;

        bool AutoUpdateFromLocator;

        string AutoUpdateLocatorDBUrl;

        bool FileTransferEnableAvatarDownload;

        bool FileTransferEnableAvatarUpload;

        bool FileTransferEnableAvatarLocators;

        bool FileTransferEnableMapDownload;

        bool FileTransferEnableMapUpload;

        bool FileTransferEnableMapLocators;

        bool FileTransferEnableMapModDownload;

        bool FileTransferEnableMapModUpload;

        bool FileTransferEnableMapModLocators;

        bool FileTransferEnableMapSkinDownload;

        bool FileTransferEnableMapSkinUpload;

        bool FileTransferEnableMapSkinLocators;

        bool FileTransferEnableTagDownload;

        bool FileTransferEnableTagUpload;

        bool FileTransferEnableTagLocators;

        bool FileTransferEnableVehicleSkinDownload;

        bool FileTransferEnableVehicleSkinUpload;

        bool FileTransferEnableVehicleSkinLocators;

        bool FileTransferEnableUnknownTypeDownload;

        bool FileTransferEnableUnknownTypeUpload;

        bool FileTransferEnableUnknownTypeLocators;

        bool IsIgnorePlayerSkins;

        bool IsSkipRollingDemo;

        bool GameProfileEnableMulti;

        string GameProfileName;

        uint PlayerInfoDisplaySize;

        string PlayerInfoDisplayType;

        bool DisableReplayRecording;

        string TmCarQuality;

        string TmCarParticleQuality;

        string PlayerShadow;

        string PlayerOccolusion;

        string TmOpponents;

        uint TmMaxOpponents;

        string TmBackgroundQuality;

        uint SmMaxPlayerResimStepPerFrame;

        bool AudioEnabled;

        string AudioDevice_Oal;

        bool AudioMuteWhenAppUnfocused;

        float AudioSoundVolume;

        float AudioMusicVolume;

        string AudioGlobalQuality;

        bool AudioAllowEFX;

        bool AudioAllowHRTF;

        bool AudioDisableDoppler;

        bool InputsAlternateMethod;

        bool InputsCaptureKeyboard;

        bool InputFreezeUnusedAxes;

        bool InputEnableRumble;

        string Advertisement_Enabled;

        float Advertisement_TunningCoef;

        bool Advertisement_DisabledByUser;

        bool EnableCrashLogUpload;

        string BlackListUrl;

        string BadWordListUrl;

        string AntiCheatServerUrl;

        string DesiredLanguageId;
    }
}
