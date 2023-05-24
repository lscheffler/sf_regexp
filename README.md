# ![Home](./docs/images/home.png "Home") SF RegExp
Wrapper for DotNet Regexp   
**Version <!--VERNO-->1.3.2<!--/VerNo-->, <!--DeploymentDate-->2023-05-24<!--/DeploymentDate-->**   
A simple class to allow easy access to the DotNet RegExp class.

---
### Synopsis
![VFPX Banner](./docs/images/vfpxbanner.gif "VFPX Banner")   
This project is part of [VFPX](https://vfpx.github.io/).

Project manager: [Lutz Scheffler](https://github.com/lscheffler)   
Project location: [SF RegExp](https://github.com/lscheffler/sf_regexp)   

The main goals of this project are:
- Allow access to the extended RegExp funcionality of the DotNet RegExp while hiding the DotNet access.
- Return VFP native objects to work with.

The problems this project tries to solve:
- Hiding the DotNet access via wwDotNetBridge
- Allow to access (parts) of the DotNet methods overloaded
- Working with the results (matches) in a VFP way
- Allow to reuse old VBasic code as good as possible.The Execute method returns a collection like VBasic, with the exception of Index starting with 1.

---
### Requirements
- Requires: Microsoft Visual Foxpro; Version 9.0 SP2, works with VFPA
- DotNet V4.8
- [wwDotNetBridge](https://west-wind.com/wwdotnetbridge.aspx), runtime is included.

---
### Installation
1. Make sure the DotNet v4.8 is available
2. This project is available to you via [Thor](https://github.com/VFPX/Thor) *Check For Updates* function.
3. If you do not use Thor, download or clone [this repository](https://github.com/lscheffler/sf_regexp).   
4. **This repository does not ship binary sources.**
5. The pjx is just to group the files, the files are intended to be included to your project.

### Use
1. To use one need all the files in the<br />
   `Execscript (_Screen.cThorDispatcher, "Tool Folder=")+'Components\SF RegExp'`<br />subfolder.
2. Make sure the DotNet v4.8 is available
3. The pjx is just to group the files, the files are intended to be included to your project.

---
### Documentation
Full help and documentation is in *PDM/index.htm* in the local folder.

For quick run see [SF RegExp Documentation](https://github.com/lscheffler/sf_regexp/blob/master/docs/documentation.md).

### Changes
See [changes](https://github.com/lscheffler/sf_regexp/blob/master/docs/changelog.md)

## Helping with this project
See [How to contribute to SF RegExp](https://github.com/lscheffler/sf_regexp/blob/master/.github/CONTRIBUTING.md) for details on how to help with this project.

----
Last changed: _<!--DeploymentDate-->2023-05-24<!--/DeploymentDate-->_   

![powered by VFPX](./docs/images/vfpxpoweredby_alternative.gif "powered by VFPX")