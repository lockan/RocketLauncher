RocketLauncher by A. Lockhart
Copyright 2014. 
Feel free to distribute, but please give credit where credit is due. 

Current Version:	Beta 0.0.1
Released:		July 8 2014

00. What Is RocketLauncher?
A windows system tray gui tool for quick-launching pretty much anything. Programs, files, scripts, batch files, etc. 
Generally speaking, if windows can recognize the command RocketLauncher should too.

01. Installation
Extract RocketLauncher.exe to any convenient folder on your PC. 
For best results, add a shortcut to your windows startup folder to force RocketLauncher to run when windows starts. 
A configuration file will be created in your local %appdata%/ folder on first run. 

02. Usage
- The RocketLauncher icon will appear in the windows task tray when the program is running. 
RocketLauncher runs minimized by default. 
- Double-clicking the tray icon will open the configuraton GUI and allow you to set Categorieds and commands for quick launching. 
- Right-clicking the icon will open the launcher context menu. Clicking an item will launch the selected program. 
- The application can be closed using the "Exit" option at the bottom of the context menu. 

02.1 Additional Usage Notes: 
- For more complex commands such as those requiring command-line switches it may be possible to create a simple batch file and link the batch file to a command in RocketLauncher rather than the trying to run the command directly. 
- If a command cannot be found you may need to edit your windows environment PATH variable to add the location of the command. 

02.2 Configuration Notes
- A configuration file will be created in your local %appdata% folder on first run. 
- The configuration file is XML format. It is entirely possibly to edit the file manually using a text editor, but I wouldn't recommend it.

03. Known Issues
- Some commands may require fully qualified file paths in order to run. 
- RocketLauncher may not be able to launch certain programs that require command line switches. 

04. Version Notes
Beta 0.0.1		July 14 2014
- Fixed a crash bug that would occur if an invalid command (e.g. file could not be found) tried to run. 

Beta 0.0.0		July 13 2014
- Initial release via dropbox
