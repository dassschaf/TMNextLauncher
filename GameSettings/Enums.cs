namespace GameSettings
{

    enum DisplayMode
    {
        fullscreen,
        windowedfull,
        windowed
    }

    enum ShaderQuality
    {
        very_fast,
        fast,
        nice,
        very_nice
    }
    
    enum TexturesQuality
    {
        very_low,
        high,
        medium,
        low
    }

    enum ShadowQuality
    {
        none,
        high
    }

    enum GeometryQuality
    {
        very_fast,
        fast,
        nice,
        very_nice
    }

    enum VehicleReflect
    {
        low,
        highinreplay,
        high
    }

    enum OnOff
    {
        on,
        off
    }

    enum BloomHdr 
    {
        medium,
        none,
        high
    }

    enum DeferredAA 
    {
        none,
        _txaa,
        _fxaa
    }

    enum TextureFiltering
    {
        anisotropic__4x,
        anisotropic__8x,
        anisotropic__16x,
        trilinear,
        bilinear
    }

    enum Presets 
    {
        very_fast,
        fast,
        nice,
        very_nice
    }

    enum LightFromMap
    {
        none,
        all_vehicles
    }

    enum AntialiasingQuality
    {
        none,
        _4_samples
    }

    enum WaterReflectQuality {
        low,
        medium
    }

    enum PlayerShadowOccolusion {
        me,
        all
    }

    enum TmOpponents {
        hide_too_close
    }

    enum TmBackgroundQuality {
        high,
        low
    }

    enum TmCarQuality {
        high_medium_opponents,
        all_high,
        all_low
    }

    enum GpuSync 
    {
        none,
        1_frame,
        2_frames,
        3_frames,
        immediate
    }
}