# How to contribute to SF RegExp

## Bug report?
- Please check  [issues](https://github.com/lscheffler/sf_regexp/issues) if the bug is reported
- If you're unable to find an open issue addressing the problem, open a new one. Be sure to include a title and clear description, as much relevant information as possible, and a code sample or an executable test case demonstrating the expected behavior that is not occurring.
### Did you write a patch that fixes a bug?
- Open a new GitHub merge request with the patch.
- Ensure the PR description clearly describes the problem and solution.
  - Include the relevant version number if applicable.

## Coding conventions
Start reading our code and you'll get the hang of it. We optimize for readability:

- Beautification is done like:
  - Keywords: Upper case 
  - Symbols: First occurence
  - Indentation: Space, 1
  - Indent anything then Comments
- We NEVER put spaces after list items and method parameters (`[1,2,3]`, not `[1, 2, 3]`), around operators (`x=1`, not `x = 1`).
- This is open source software. Consider the people who will read your code, and make it look nice for them. It's sort of like driving a car: Perhaps you love doing donuts when you're alone, but with passengers the goal is to make the ride as smooth as possible.
- Please kindly add comments where and what you change.
  Prefered in PDM change style, this will be processed into documentation. Please look up the examples in the code.

## Fix a bug or add an enhancement
Please note, there are some tasks to set up a new version.
Stuff is a bit scattered, so this is where to look up.
1. Please create a fork at github
  - Fork the project: see this [guide](https://www.dataschool.io/how-to-contribute-on-github/) for setting up and using a fork.
  - If allready forked, pull the recent state, or get most recent version otherwise.
3. On top of *SF_RegExp.h* there is a #DEFINE with version numbers, change according:   
`#DEFINE dcRegExpVerNo "0.0.0"`
4. Add a description of changes to *./Doku/Source/Changes.html* (this is for PDM docu)
5. For changed functionality, add descriptive text to *./Doku/Source/Preface.html* file. (this is for PDM docu)
6. Change version number on top of *./Doku/Source/Preface.html* file.
7. Highlight the change on *README.md* in projects root
8. Add a description of changes to *docs/changelog.md* (this is for github docu)
9. Change date in the footer of documentation files touched.
10. If available run PDM <a href="http://gorila.netlab.cz/pdm.html" title="PDM"  target="_blank">Project Documenting Machine</a> by Martina Jindrová using the AB-plugins.
  The pdm setting is stored in the *./Doku* folder.
11. Commit the changes.
12. Push to your fork.
13. Create a pull request; ensure the description clearly describes the problem and solution or the enhancement.

Thanks

----
Last changed: 2023-07-28

![powered by VFPX](../docs/images/vfpxpoweredby_alternative.gif "powered by VFPX")