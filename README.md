# ![](content/home.png "Home") SF RegExp
Wrapper for DotNet Regexp   
**Version 1.1.000, 2023-05-05**   
A simple class to allow easy access to the DotNet RegExp class.

---
### Synopsis
This is project is part of [VFPX](https://vfpx.github.io/) 

![VFPX](https://vfpx.github.io/images/vfpxbanner_small.gif)

![VFPX](https://github.com/lscheffler/sf_regexp/blob/master/content/vfpxlogo.gif "VFPX")

Project manager: [Lutz Scheffler](https://github.com/lscheffler)   
Project location: [SF RegExp](https://github.com/lscheffler/sf_regexp)   

The main goals of this project are:
- Allow access to the extended RegExp funcionality of the DotNet RegExp while hiding the DotNet access.
- Return VFP native objects to work with.

The problems this project tries to solve:
- Hiding the DotNet access via wwDotNetBridge
- Allow to access (parts) of the DotNet methods overloaded
- Working with the results (matches) in a VFP way

---
### Requirements
- Requires: Microsoft Visual Foxpro; Version 9.0 SP2, works with VFPA
- DotNet V4.8
- [wwDotNetBridge](https://west-wind.com/wwdotnetbridge.aspx), runtime is included.

---
### Installation
1. Download or clone [this repository](https://github.com/lscheffler/sf_regexp).   
2. Make sure the DotNet v4.8 is available
9. **This repository does not ship binary sources.**
3. The pjx is just to group the files, the files are intended to be included to your project.

### Use
1. To use one need all the files in the *SF_RegExp* subfolder
2. Make sure the DotNet v4.8 is available
3. The pjx is just to group the files, the files are intended to be included to your project.

---
### Documentation
Full help and documentation is in *docs/index.htm* in the download file.

For quick run see [SF RegExp Documentation](https://github.com/lscheffler/sf_regexp/blob/master/content/documentation.md).

### Changes
See [changes](https://github.com/lscheffler/sf_regexp/blob/master/content/change_log.md)

## Helping with this project
See [How to contribute to SF RegExp](https://github.com/lscheffler/sf_regexp/blob/master/.github/CONTRIBUTING.md) for details on how to help with this project.

----
Last changed: _2023/05/05_ ![Powered by VFPX](https://github.com/lscheffler/sf_regexp/blob/master/content/vfpxpoweredby_alternative.gif)