cmake_minimum_required(VERSION 3.9)
project(Magick.NET.Native C)

if (${HDRI})
    set(HDRI_SUFFIX HDRI)
    set(HDRI_DASH -)
endif()

set(TARGET_NAME Magick.NET-Q${QUANTUM_DEPTH}-${HDRI_SUFFIX}${HDRI_DASH}x64.Native.dll)

if(CMAKE_SYSTEM_NAME STREQUAL Darwin)
    include_directories(SYSTEM /usr/local/include)
endif()

find_package(PkgConfig REQUIRED)
find_package(JPEG REQUIRED)

pkg_check_modules(IM MagickWand-7.Q${QUANTUM_DEPTH}${HDRI_SUFFIX} REQUIRED)

add_definitions(-DMAGICK_NET_LINUX -DMAGICKCORE_QUANTUM_DEPTH=${QUANTUM_DEPTH} -DMAGICKCORE_HDRI_ENABLE=${HDRI})

include_directories(. ${IM_INCLUDE_DIRS})

add_library(${TARGET_NAME} SHARED
        Stdafx.c
        Stdafx.h
        MagickFormatInfo.c
        MagickFormatInfo.h
        MagickImage.c
        MagickImage.h
        MagickImageCollection.c
        MagickImageCollection.h
        MagickNET.c
        MagickNET.h
        Quantum.c
        Quantum.h
        ResourceLimits.c
        ResourceLimits.h
        Colors/MagickColor.c
        Colors/MagickColor.h
        Colors/MagickColorCollection.c
        Colors/MagickColorCollection.h
        Drawables/DrawingWand.c
        Drawables/DrawingWand.h
        Drawables/PointInfoCollection.c
        Drawables/PointInfoCollection.h
        Exceptions/MagickExceptionHelper.c
        Exceptions/MagickExceptionHelper.h
        Helpers/Environment.c
        Helpers/Environment.h
        Helpers/MagickMemory.c
        Helpers/MagickMemory.h
        Matricis/DoubleMatrix.c
        Matricis/DoubleMatrix.h
        OpenCL/OpenCL.c
        OpenCL/OpenCL.h
        OpenCL/OpenCLDevice.c
        OpenCL/OpenCLDevice.h
        OpenCL/OpenCLKernelProfileRecord.c
        OpenCL/OpenCLKernelProfileRecord.h
        Optimizers/JpegOptimizer.c
        Optimizers/JpegOptimizer.h
        Pixels/PixelCollection.c
        Pixels/PixelCollection.h
        Resources/resource.h
        Settings/DrawingSettings.c
        Settings/DrawingSettings.h
        Settings/MagickSettings.c
        Settings/MagickSettings.h
        Settings/MontageSettings.c
        Settings/MontageSettings.h
        Settings/QuantizeSettings.c
        Settings/QuantizeSettings.h
        Statistics/ChannelMoments.c
        Statistics/ChannelMoments.h
        Statistics/ChannelPerceptualHash.c
        Statistics/ChannelPerceptualHash.h
        Statistics/ChannelStatistics.c
        Statistics/ChannelStatistics.h
        Statistics/Moments.c
        Statistics/Moments.h
        Statistics/PerceptualHash.c
        Statistics/PerceptualHash.h
        Statistics/Statistics.c
        Statistics/Statistics.h
        Types/ConnectedComponent.c
        Types/ConnectedComponent.h
        Types/MagickGeometry.c
        Types/MagickGeometry.h
        Types/MagickRectangle.c
        Types/MagickRectangle.h
        Types/OffsetInfo.c
        Types/OffsetInfo.h
        Types/PointInfo.c
        Types/PointInfo.h
        Types/PrimaryInfo.c
        Types/PrimaryInfo.h
        Types/StringInfo.c
        Types/StringInfo.h
        Types/TypeMetric.c
        Types/TypeMetric.h
        )

target_link_libraries(${TARGET_NAME} ${IM_LIBRARIES} ${JPEG_LIBRARIES})