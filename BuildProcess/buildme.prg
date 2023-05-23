*BuildMe.prg for [add your application]
*
* This program should perform any build tasks necessary for the project, such
* as updating version numbers in code or include files. This program can use the public
* variables discussed in the documentation as necessary.

LOCAL lcExec
*:Global pcFullVersion
TEXT TO m.lcExec NOSHOW
#Include Source\SF_RegeXp.h
pcVersion     = dcRegExpVerNo
pcFullVersion = m.pcVersion
ENDTEXT &&lcExec

EXECSCRIPT(m.lcExec)
RETURN

*Stuff we can do:
* - get version number (pcVersion) from an include file
* - set version number (pcVersion) to an include file
* - set version number to pjx used
* - set debug info off in pjx or include file
* - If FoxBin2Prg internal to VFPXDeployment is not fitting, run own way
* - create pcFullVersion like you use in the .VersionNumber of Version*.txt file for use in README.md
*   (else it will use pcVersion)
*   like the example in the Version text template:
pcFullVersion = pcVersion+' - ' + pcJulian
* - copy files to ../InstalledFiles subfolder
* - modify documentation
