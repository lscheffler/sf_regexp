lparameters toUpdateObject

* Set the properties of the passed updater object.

with toUpdateObject
	.VersionNumber    = '1.3.002 - 20230517'
	.AvailableVersion = 'SF RegExp-1.3.002-update-20230517'
	.Notes            = GetNotes()
	.RegisterWithThor = GetRegisterWithThor()
endwith
return toUpdateObject

* Get the notes for the project.

procedure GetNotes
local lcNotes
text to lcNotes noshow
# SF RegExp Change list

{Abbreviated project description}

## Release History

### {Release date as YYYY-MM-DD}, Version {Version number}}

* {List of changes}

----
Last changed: 2023-05-17

![powered by VFPX](./images/vfpxpoweredby_alternative.gif)
endtext
return lcNotes

* Register the tool with Thor. Note: Thor replaces ##InstallFolder## with the
* installation path for the tool when this code is executed.

procedure GetRegisterWithThor
local lcCommand
text to lcCommand noshow

endtext
return lcCommand
