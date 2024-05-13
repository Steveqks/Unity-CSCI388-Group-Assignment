#ifndef SFX_KEYWORD_DEFINES
#define SFX_KEYWORD_DEFINES

#define X_FEATURES defined(SFXX)

#define MAIN_PASS defined(MAIN)

#define TRIPLANAR_PASS defined(TRIPLANAR)

#define ZOOM_PASS defined(ZOOM)

#define COLOR_ENABLED defined(_COLOR_ON)

#define SHAKE_ENABLED defined(_SHAKE_ON)

#define DISTORTION_ENABLED defined(_DISTORTION_ON)

#define DISTORTION_WORLD_ENABLED defined(_DISTORTION_WORLD_ON)

#define BLUR_PIXEL_ENABLED defined(_BLUR_PIXEL_ON)

#define BLUR_DITHER_ENABLED defined(_BLUR_DITHER_ON)

#define BLUR_RADIAL_ENABLED defined(_BLUR_RADIAL_ON)

#define BLUR_Y_ENABLED defined(_BLUR_Y_ON)

#define BLUR_ENABLED defined(_BLUR_PIXEL_ON) || defined(_BLUR_DITHER_ON) || defined(_BLUR_RADIAL_ON)

#define CHROM_ABB_ENABLED defined(_CHROMATIC_ABBERATION_ON)

#define DOF_ENABLED defined(_DOF_ON)

#define ZOOM_ENABLED defined(_ZOOM_ON)

#define ZOOM_RGB_ENABLED defined(_ZOOM_RGB_ON)

#define IMAGE_OVERLAY_ENABLED defined(_IMAGE_OVERLAY_ON)

#define IMAGE_OVERLAY_DISTORTION_ENABLED defined(_IMAGE_OVERLAY_DISTORTION_ON)

#define FOG_ENABLED defined(_FOG_ON)

#define TRIPLANAR_ENABLED defined(_TRIPLANAR_ON)

#define OUTLINE_ENABLED defined(_OUTLINE_ON)

#define NOISE_ENABLED defined(_NOISE_ON)

#define AUDIOLINK_ENABLED defined(_AUDIOLINK_ON)

#define SOBEL_FILTER_ENABLED defined(_SOBEL_FILTER_ON)

#endif