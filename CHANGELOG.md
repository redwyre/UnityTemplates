# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.5] - 2024-07-14

### Added

- Added template for IJobEntity
- Added template for Struct with Unity DOTS related usings

### Changed

- Fixed IEnableableComponent template not deriving from IComponentData
- Removed double naming on Aspect, Authoring, ISystem, and SystemBase templates
- Removed UnityEngine namespace from unmanged files
- Added [BurstCompile] to IJob, IJobFor, and IJobParallelFor templates
- Removed IJobEntity job from inside ISystem template
- Added example use of SystemAPI.Query and job in SystemBase template
- Removed "I" prefix from default names

## [1.4] - 2024-03-30

### Added

- Added template for IJob
- Added template for IJobFor
- Added template for IJobParallelFor
- Added template for StateMachineBehaviour

## [1.3] - 2023-10-15

### Added

- Added template for Class (Unity usings)
- Added template for Assembly Definition
- Added template for Assembly Definition Reference

## [1.2] - 2023-07-15

### Changed

- Changed icons
- Update description

### Added

- Added template for ICleanupComponentData
- Added template for IComponentData (managed)
- Added template for IEnableableComponent
- Added template for ISharedComponent


## [1.1] - 2023-06-28

### Changed

- Renamed project to "UnityTemplates"

### Added

- Added template for ScriptableObject
- Added some more description in VSIX metadata
- Added arm64 target to VSIX

## [1.0] - 2023-06-27

### Added

- VSIX for Visual Studio 2022
- Aspect template
- Authoring Component template
- IBufferElementData template
- IComponentData template
- ISystem template
- SystemBase template
- MonoBehaviour template
