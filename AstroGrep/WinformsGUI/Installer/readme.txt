Changelog for AstroGrep v4.4.6
===================================================================
Bugs
-97: Encoding detection cache fails if file encoding changes
-95: Duplicate shortcut keys in some languages
-92: Exclusion viewing causes crash
-90: "Print Results..." + All option outputs a blank page
-89: "Save Results..." functionality is broken
-88: Difficulties to open the exclusions form

Featured Requests:
-120: Add option to change/​default to black the search panel labels.
-113: Create menu item for donation
-109: Allow showing more context lines (maximum of 25 now)
-108: Add additional text editor parameter for search text. (use %4 in command line for text editors)
-107: Date range search option (added time selection)

Patches:
-6: Unable to compile source code fix (linknet)
-4: Fixing exception due to missing key in registry (Anonymous)
-3: add %4 parameter to open editor which contains the searched text (maitob)
-2: French translation (Stéphane Aulery)

Other:
- Made common assembly information and shared between projects (makes all projects have same version)
- Added Windows 10 start icon background color and larger image support
- Updated Spanish translations file from user Miguel

Special thanks to user linknet for the following as well:
- Fix: frmMain unable to be opened in Visual Studio designer
- Fix: frmMain randomly resizing elements when opened in Visual Studio designer
- Fix: added the new keyword where required to prevent compiler warnings
- Fix: added missing xml declarations where required to prevent compiler warnings
- Fix: application not centered on screen on initial startup
- Fix: application initial startup width increased to include all screen elements 
- Fix: application not scaling correctly with high DPI% settings - now scales correctly
- Fix: results window text not scaling correctly with high DPI% settings - now scales correctly
- Fix: list view columns not scaling correctly with high DPI% settings - now scale correctly
- Fix: reset all window and column positions and fonts to default values with a change of DPI% setting.
- CHG: increased interface font size from 8 to 9 points
- Add: exclusions window now resizeable with window and column position settings saved
