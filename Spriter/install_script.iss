;InnoSetupVersion=5.5.7

[Setup]
AppName=Spriter
AppVersion=r11
AppPublisher=BrashMonkey, LLC
AppPublisherURL=http://www.BrashMonkey.com
AppSupportURL=http://www.BrashMonkey.com
AppUpdatesURL=http://www.BrashMonkey.com
DefaultDirName={pf}\Spriter
DefaultGroupName=Spriter
OutputBaseFilename=Spriter_r11
Compression=lzma
DisableDirPage=auto
DisableProgramGroupPage=auto
LicenseFile=embedded\License.txt
WizardImageFile=embedded\WizardImage.bmp
WizardSmallImageFile=embedded\WizardSmallImage.bmp

[Files]
Source: "{app}\CORE_RL_and_IM_MOD_ImageMagickLicense.txt"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\CORE_RL_bzlib_.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\CORE_RL_glib_.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\CORE_RL_lcms_.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\CORE_RL_lqr_.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\CORE_RL_Magick++_.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\CORE_RL_magick_.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\CORE_RL_png_.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\CORE_RL_ttf_.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\CORE_RL_wand_.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\CORE_RL_zlib_.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\icudt54.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\icuin54.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\icuuc54.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\IM_MOD_RL_gif_.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\IM_MOD_RL_png_.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5CLucene.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5Core.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5Gui.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5Help.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5Multimedia.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5MultimediaWidgets.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5Network.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5OpenGL.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5Positioning.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5PrintSupport.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5Qml.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5Quick.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5Script.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5Sensors.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5Sql.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5WebChannel.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5WebKit.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5WebKitWidgets.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Qt5Widgets.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\ReadMeQtLGPL.txt"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Spriter.exe"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\SpriterEULA.txt"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\SpriterHelp.qch"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\SpriterHelp.qhc"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\startuplog.txt"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\steam_api.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\.SpriterHelp\deletable"; DestDir: "{app}\.SpriterHelp"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\.SpriterHelp\segments"; DestDir: "{app}\.SpriterHelp"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\.SpriterHelp\_3d.cfs"; DestDir: "{app}\.SpriterHelp"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\audio\qtaudio_windows.dll"; DestDir: "{app}\audio"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\acknowlegements.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\activating and stacking character maps.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\adding additional sprites to an animation.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\adding collision rectangles to frames.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\adding event triggers to an animation.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\adding sound effects.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\adding spawning points to frames.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\adding tags to an animation.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\adding variables to an animation.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\adjusting z orders.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\advanced timeline editing.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\animating sprites and bones.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\batch exporting animations from character files.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\colored clones of your project.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\copying individual atributes to all frames.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\create a character map and assign effects.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\creating a clone of your project that uses texture atlases.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\creating a scaled clone of an entire project.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\creating and assigning bones.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\creating custom trimming settings for each animation.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\default pivot points.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\duplicating entire keyframes.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\editing timing.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\exporting animations as images or gifs.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\getting started.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\importing one spriter project into another.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\key all vs key selected.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\mouse and keyboard controls.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\papagoyo support.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\placing a sprite.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\saving character map sets as character files.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\starting a project.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\swapping the image of a sprite.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\texturepacker support.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\using spriters custom color features.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\what are character maps.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\what is spriter.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\0.gif"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\191.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\196.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\197.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\198.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\199.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\200.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\201.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\202.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\203.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\204.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\205.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\206.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\207.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\208.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\209.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\210.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\211.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\212.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\213.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\214.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\215.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\216.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\218.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\220.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\221.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\223.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\224.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\225.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\226.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\227.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\229.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\230.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\231.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\232.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\233.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\234.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\235.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\236.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\237.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\238.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\239.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\240.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\241.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\242.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\243.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\244.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\245.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\247.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\248.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\249.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\251.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\252.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\253.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\254.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\255.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\256.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\257.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\258.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\259.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\261.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\262.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\263.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\264.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\265.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\266.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\269.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\270.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\271.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\272.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\351.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\352.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\409.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\410.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\412.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\413.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\414.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\415.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\416.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\417.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\418.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\419.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\420.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\421.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\423.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\424.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\425.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\426.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\428.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\429.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\430.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\431.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\432.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\433.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\434.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\440.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\441.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\442.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\443.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\445.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\446.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\447.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\448.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\449.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\450.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\451.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\452.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\453.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\476.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\506.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\507.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\508.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\509.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\510.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\553.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\554.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\555.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\556.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\557.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\558.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\559.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\560.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\608.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\609.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\621.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\622.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\623.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\624.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\625.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\758.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\770.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\ani.css"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\custom_styles.css"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\png.js"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\replaceMobileFonts.js"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\roe.js"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\XaraWDEmbeddedHTMLfont1.eot"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\XaraWDEmbeddedHTMLfont1.ttf"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\XaraWDEmbeddedHTMLfont2.eot"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\XaraWDEmbeddedHTMLfont2.ttf"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\xr_files.txt"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\xr_fonts.css"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\xr_fontsie.css"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\xr_main.css"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\docs\index_htm_files\xr_text.css"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\imageformats\qgif.dll"; DestDir: "{app}\imageformats"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\imageformats\qjpeg.dll"; DestDir: "{app}\imageformats"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\mediaservice\dsengine.dll"; DestDir: "{app}\mediaservice"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\mediaservice\qtmedia_audioengine.dll"; DestDir: "{app}\mediaservice"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\mediaservice\wmfengine.dll"; DestDir: "{app}\mediaservice"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\platforms\qwindows.dll"; DestDir: "{app}\platforms"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\sqldrivers\qsqlite.dll"; DestDir: "{app}\sqldrivers"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\TexturePackerTemplates\SpriterFree.tps"; DestDir: "{app}\TexturePackerTemplates"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\TexturePackerTemplates\SpriterMaxRects.tps"; DestDir: "{app}\TexturePackerTemplates"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\phonon4.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\QtCLucene4.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\QtCore4.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\QtGui4.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\QtHelp4.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\QtNetwork4.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\QtOpenGL4.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\QtScript4.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\QtSql4.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\QtWebKit4.dll"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qcncodecs4.dll"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qcncodecs4.lib"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qcncodecsd4.dll"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qcncodecsd4.lib"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qjpcodecs4.dll"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qjpcodecs4.lib"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qjpcodecsd4.dll"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qjpcodecsd4.lib"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qkrcodecs4.dll"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qkrcodecs4.lib"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qkrcodecsd4.dll"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qkrcodecsd4.lib"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qtwcodecs4.dll"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qtwcodecs4.lib"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qtwcodecsd4.dll"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\codecs\qtwcodecsd4.lib"; DestDir: "{app}\codecs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\acknowledgements.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\adding action points to frames.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\adding events to an animation.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\create a character map.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\mouse controls and shortcut keys.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\papagayo support.htm"; DestDir: "{app}\docs"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\130.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\131.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\132.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\133.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\134.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\135.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\136.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\16.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\17.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\18.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\19.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\20.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\21.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\217.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\219.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\22.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\222.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\228.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\23.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\24.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\246.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\25.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\250.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\26.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\260.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\267.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\268.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\27.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\274.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\275.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\276.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\277.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\278.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\279.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\28.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\281.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\282.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\283.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\284.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\29.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\30.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\31.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\34.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\375.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\376.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\377.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\52.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\53.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\54.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\55.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\56.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\57.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\61.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\62.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\63.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\64.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\65.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\66.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\67.png"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\docs\index_htm_files\98.jpg"; DestDir: "{app}\docs\index_htm_files"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\imageformats\qgif4.dll"; DestDir: "{app}\imageformats"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\imageformats\qjpeg4.dll"; DestDir: "{app}\imageformats"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\phonon_backend\phonon_ds94.dll"; DestDir: "{app}\phonon_backend"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\phonon_backend\phonon_ds94.lib"; DestDir: "{app}\phonon_backend"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\phonon_backend\phonon_ds9d4.dll"; DestDir: "{app}\phonon_backend"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 
Source: "{app}\phonon_backend\phonon_ds9d4.lib"; DestDir: "{app}\phonon_backend"; MinVersion: 0.0,5.0; Flags: deleteafterinstall onlyifdestfileexists ignoreversion 

[Registry]
Root: HKCR; Subkey: ".scml"; ValueType: String; ValueData: "SpriterDocument"; MinVersion: 0.0,5.0; Flags: uninsdeletevalue 
Root: HKCR; Subkey: "SpriterDocument"; ValueType: String; ValueData: "Sprite Document"; MinVersion: 0.0,5.0; Flags: uninsdeletekey 
Root: HKCR; Subkey: "SpriterDocument\shell\open\command"; ValueType: String; ValueData: """{app}\Spriter.exe"" ""%1"""; MinVersion: 0.0,5.0; 

[Run]
Filename: "{app}\Spriter.exe"; Description: "{cm:LaunchProgram,Spriter}"; MinVersion: 0.0,5.0; Flags: postinstall skipifsilent nowait

[Icons]
Name: "{group}\Spriter"; Filename: "{app}\Spriter.exe"; MinVersion: 0.0,5.0; 
Name: "{group}\{cm:UninstallProgram,Spriter}"; Filename: "{uninstallexe}"; MinVersion: 0.0,5.0; 
Name: "{commondesktop}\Spriter"; Filename: "{app}\Spriter.exe"; Tasks: desktopicon; MinVersion: 0.0,5.0; 

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; MinVersion: 0.0,5.0; 

[CustomMessages]
english.NameAndVersion=%1 version %2
english.AdditionalIcons=Additional shortcuts:
english.CreateDesktopIcon=Create a &desktop shortcut
english.CreateQuickLaunchIcon=Create a &Quick Launch shortcut
english.ProgramOnTheWeb=%1 on the Web
english.UninstallProgram=Uninstall %1
english.LaunchProgram=Launch %1
english.AssocFileExtension=&Associate %1 with the %2 file extension
english.AssocingFileExtension=Associating %1 with the %2 file extension...
english.AutoStartProgramGroupDescription=Startup:
english.AutoStartProgram=Automatically start %1
english.AddonHostProgramNotFound=%1 could not be located in the folder you selected.%n%nDo you want to continue anyway?

[Languages]
; These files are stubs
; To achieve better results after recompilation, use the real language files
Name: "english"; MessagesFile: "embedded\english.isl"; 
