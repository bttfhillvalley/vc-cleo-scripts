@echo off
set SANNY_EXE="sanny.exe"

REM Sanny can only compile if its not already running
tasklist /fi "IMAGENAME eq sanny.exe" /FO CSV 2>NUL | find /I /N "sanny.exe">NUL
if %ERRORLEVEL% EQU 0 (
    echo Sanny is running.  Please close it before running this build script.
    pause
    exit /B 1
)

REM Check to see if executable is in path
where /q %SANNY_EXE%
reg query "HKLM\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\Sanny Builder 3_is1" /v "InstallLocation" >nul
if %ERRORLEVEL% equ 1 (
    echo Sanny not found in PATH.  Please select the location of sanny.exe, or set the PATH to include it
    call :filedialog SANNY_EXE
) else (
where /q %SANNY_EXE%
for /f "tokens=2*" %%a in ('REG QUERY "HKLM\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\Sanny Builder 3_is1" /v "InstallLocation"') do set "SANNY_EXE=%%bSanny.exe"
)

echo Compiling scripts...

:: Marty Skin Override
call :Compile Marty .cs

:: Death Script
call :Compile Dead .cs

:: Pickup scripts
call :Compile Pickups .cs
call :Compile Pickups\Health .s
call :Compile Pickups\Whiskey .s

:: Walkman scripts
call :Compile Pickups\WalkmanSpawn .s
call :Compile Pickups\Walkman .s

::Weapon pickup scripts
call :Compile Pickups\Griff .s

:: Health Pickups
call :Compile Pickups\TCHealth .s
call :Compile Pickups\SodaCan .s
call :Compile Pickups\SodaGlass .s
call :Compile Pickups\SodaPlastic .s

:: Hoverboard and Skateboard scripts
call :Compile Boards .cs
call :Compile Boards\BoardDrop .s
call :Compile Boards\BoardHacks .s
call :Compile Boards\BoardHold .s
call :Compile Boards\BoardPush .s
call :Compile Boards\Handlebars .s
call :Compile Boards\BoardGrab .s

:: Time Changing Building Scripts
call :Compile Map .cs
call :Compile Map\BarberPole .s
call :Compile Map\55_News .s
call :Compile Map\BarnProps .s
call :Compile Map\Clocktower_News .s
call :Compile Map\DocDoor .s
call :Compile Map\MallClock .s
call :Compile Map\TwinPinesRipple .s
call :Compile Map\UFO_News .s
call :Compile Map\DogFood .s
call :Compile Map\DogFoodMachine\Coffee .s
call :Compile Map\DogFoodMachine\Timer1 .s
call :Compile Map\DogFoodMachine\Timer2 .s
call :Compile Map\DogFoodMachine\Timer3 .s
call :Compile Map\DogFoodMachine\Toast .s
call :Compile Map\DogFoodMachine\ToastSmoke .s
call :Compile Map\DogFoodMachine\TVReport .s


echo The compiling process is now complete.
pause
exit /B 0

:Compile
echo Compiling %~1 as %~2
"%SANNY_EXE%" --game vc --no-splash --compile "%~dp0\%~1.txt" "%~dp0\%~1%~2"

exit /B 0


:filedialog :: &file
setlocal
set dialog="about:<input type=file id=FILE><script>FILE.click();new ActiveXObject
set dialog=%dialog%('Scripting.FileSystemObject').GetStandardStream(1).WriteLine(FILE.value);
set dialog=%dialog%close();resizeTo(0,0);</script>"
for /f "tokens=* delims=" %%p in ('mshta.exe %dialog%') do set "file=%%p"
endlocal  & set %1=%file%
exit /B 0
