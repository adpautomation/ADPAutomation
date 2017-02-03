rem ******************************************************************
rem  UI Builder
rem ******************************************************************

rem @echo off

cls

if [%1%]==[] (
	SET PRG_DRIVE=D:
	SET PRG_FOLDER=\Builds\Wks\Mobile\D
)
if [%1%]==[1] (
	SET PRG_DRIVE=D:
	SET PRG_FOLDER=\Builds\Wks\Mobile\D
)
if [%1%]==[2] (
	SET PRG_DRIVE=D:
	SET PRG_FOLDER=\Builds\Wks\Mobile\R
)
if [%1%] == [3] (
	SET PRG_DRIVE=D:
	SET PRG_FOLDER=\Builds\Wks\Mobile\R
)

rem %SystemRoot%\system32;%SystemRoot%;%SystemRoot%\System32\Wbem;%SYSTEMROOT%\System32\WindowsPowerShell\v1.0\;C:\Program Files\Microsoft SQL Server\Client SDK\ODBC\110\Tools\Binn\;C:\Program Files (x86)\Microsoft SQL Server\120\Tools\Binn\;C:\Program Files\Microsoft SQL Server\120\Tools\Binn\;C:\Program Files\Microsoft SQL Server\120\DTS\Binn\;C:\Program Files (x86)\Microsoft SQL Server\120\Tools\Binn\ManagementStudio\;C:\Program Files (x86)\Microsoft SQL Server\120\DTS\Binn\;D:\UI_Stack\nodejs\;%USERPROFILE%\.dnx\bin;C:\Program Files\Microsoft DNX\Dnvm\;D:\UI_Stack\npm_global;D:\UI_Stack\nodejs;C:\Program Files (x86)\Git;C:\Program Files (x86)\Git\cmd;C:\Program Files (x86)\Git\Bin;D:\UI_Stack\npm_global\node_modules;D:\UI_Stack\nodejs\node_modules\npm
REM @echo off
REM echo Hello World from %AGENT_NAME%.
REM echo My ID is %AGENT_ID%.
REM echo AGENT_WORKFOLDER contents:
REM @dir %AGENT_WORKFOLDER%
REM echo AGENT_BUILDDIRECTORY contents:
REM @dir %AGENT_BUILDDIRECTORY%
REM echo BUILD_SOURCESDIRECTORY contents:
REM @dir %BUILD_SOURCESDIRECTORY%
REM echo Over and out.

SET DEPLOY_FOLDER=\\DOTNETDEVWS\bsg-mobile-dev
SET PATH=%PATH%;D:\UI_Stack\nodejs\node_modules\npm;D:\UI_Stack\npm_global\node_modules;C:\Program Files (x86)\Git\cmd;C:\Program Files (x86)\Git\bin
SET WORKSPACE=DC1PRTFSNET1;nunezca
SET JS_FOLDER=dist
SET PRG_NAME=Mobile.Web.vbproj
SET TFS_EXE="C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\tf.exe"
SET BLD_EXE="D:\Builds\Scripts\PrjCmd\PrjCmd.exe"
SET BAT_VERSION=4.0_3_31_2016
SET BATCH_LOCATION=D:\Builds\Scripts

cls

echo ****************************************************************** go to folder: CD /D %BUILD_SOURCESDIRECTORY%
cd /D %BUILD_SOURCESDIRECTORY%

echo ****************************************************************** get latest and check out all dist files
rem %TFS_EXE% undo  %PRG_DRIVE%\%PRG_FOLDER%\*.* /noprompt /recursive
rem %TFS_EXE% get  %PRG_DRIVE%\%PRG_FOLDER%\*.* /noprompt /recursive /force
rem %TFS_EXE% checkout %PRG_DRIVE%\%PRG_FOLDER%\%JS_FOLDER%\*.* /recursive
DEL D:\Builds\Scripts\tf_old_files.txt
%TFS_EXE% checkout %BUILD_SOURCESDIRECTORY%\%JS_FOLDER%\*.* /recursive
%TFS_EXE% dir %BUILD_SOURCESDIRECTORY%\%JS_FOLDER%\*.* /version:T /recursive > D:\Builds\Scripts\tf_old_files.txt

echo ****************************************************************** Gulp build 
call npm install
IF ERRORLEVEL 1 GOTO FAILED
call bower install
IF ERRORLEVEL 1 GOTO FAILED
call gulp clean
call gulp build
IF ERRORLEVEL 1 GOTO FAILED

echo ****************************************************************** command to update project files and indicate what needs to be removed/added from TFS
%BLD_EXE% eval %BUILD_SOURCESDIRECTORY% %JS_FOLDER% %PRG_NAME%
IF ERRORLEVEL 1 GOTO FAILED

echo ****************************************************************** Execute batch to save the changes in TFS
call %BATCH_LOCATION%\delfiles.bat %TFS_EXE%  %BUILD_SOURCESDIRECTORY%
call %BATCH_LOCATION%\addfiles.bat %TFS_EXE%  %BUILD_SOURCESDIRECTORY%
IF ERRORLEVEL 1 GOTO FAILED

%TFS_EXE% checkin %BUILD_SOURCESDIRECTORY%\*.* /recursive /noprompt /comment:"AUTO: Latest Gulp Build  (v%BAT_VERSION%) ***NO_CI***"
IF ERRORLEVEL 1 GOTO FAILED

echo ******************************************************************
echo                All Done!		   
echo ******************************************************************
GOTO END

:FAILED
echo ******************************************************************
echo              An error ocurred - build not completed
echo ******************************************************************
exit /b 1

:END
exit /b 0
