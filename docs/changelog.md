# SF RegExp Change list

Wrapper for DotNet Regexp

## Release History

This page gives a brief overview of changes to the [SF RegExp](https://github.com/lscheffler/sf regexp).

A complete list of changes is available on the offline documentation via **local folder** _PDM/index.htm_.

---
### Version 1.3.2 **2023/05/10**
- New: Added Global property for use in Execute method

### Version 1.3.1 **2023/05/10**
- New: Match objects returned by Execute method now own a FirstIndex property that works like VBasic.
- Improved: The Test prg now owns a Test_Execute procedure.

### Version 1.3.0 **2023/05/09**
- New: Method Execute to work like VBasic. Note, Collection starts with 1.
- Improved: Property AutoExpandGroup renamed to AutoExpandGroups for better self description.
- Improved: Some flaws in the documentation.

### Version 1.2.0 **2023/05/09**
- Imporved: Show_Unwind now deals VFP and DotNet; Match and Matches objects
- Internal: Some properties and methods protected

### Version 1.1.0 **2023/05/05**
- Imporved: New method Show_Unwind to show the complete structure of a Matches object
- Stability: Stability on recall, use of paths

### Version 1.0.0


----
Last changed: <!--DeploymentDate-->2023-05-17<!--/DeploymentDate-->

![powered by VFPX](./images/vfpxpoweredby_alternative.gif "powered by VFPX")