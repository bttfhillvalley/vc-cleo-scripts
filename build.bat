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
:: Main scripts
call :Compile BTTFHVInit .cs
call :Compile CarSpawn .cs
call :Compile DeloreanCleanup .cs
call :Compile DisplayToggle .cs
call :Compile Plutonium .cs
call :Compile RemoteControl .cs
call :Compile Speed .cs
call :Compile TextureDictionary .cs
call :Compile TimeMod .cs
call :Compile TimeTravelMode .cs
call :Compile Wanted .cs
call :Compile Weather .cs

:: Plutonium scripts
call :Compile PlutoniumText .s

:: Delorean scripts
call :Compile Delorean .s
call :Compile Delorean\Bonnet .s
call :Compile Delorean\Cold .s
call :Compile Delorean\Dashboard .s
call :Compile Delorean\Door .s
call :Compile Delorean\FuelEmpty .s
call :Compile Delorean\HookDetach .s
call :Compile Delorean\HoverAnimate .s
call :Compile Delorean\Interior .s
call :Compile Delorean\Past .s
call :Compile Delorean\Pedals .s
call :Compile Delorean\Plate .s
call :Compile Delorean\PlutoniumGauge .s
call :Compile Delorean\ReentryCoils .s
call :Compile Delorean\SID .s
call :Compile Delorean\Steam .s
call :Compile Delorean\TurnSignal .s
call :Compile Delorean\UnderbodyLights .s
call :Compile Delorean\Variation .s
call :Compile Delorean\WheelThrust .s
call :Compile Delorean\Wipers .s

:: Time Circuit scripts
call :Compile TimeCircuits .s
call :Compile TimeCircuits\Flash .s
call :Compile TimeCircuits\Keypad .s
call :Compile TimeCircuits\On .s
call :Compile TimeCircuits\Error .s

:: Time Travel scripts
call :Compile Time\Firetrail .s
call :Compile Time\FireTrail99 .s
call :Compile Time\Lightning .s
call :Compile Time\Sparks .s

:: JVT Train scripts
call :Compile TimeTrain .s
call :Compile TimeTrain\Animation .s
call :Compile TimeTrain\Cold .s
call :Compile TimeTrain\Door .s
call :Compile TimeTrain\Effects .s
call :Compile TimeTrain\HoverAnimate .s
call :Compile TimeTrain\Past .s
call :Compile TimeTrain\ReentryCoils .s
call :Compile TimeTrain\Thrust .s
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
