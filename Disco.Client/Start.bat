@ECHO OFF
IF /I "%USERDOMAIN%"=="NT AUTHORITY" GOTO RunAsNetworkService
Disco.Client.exe
EXIT /B 0

:RunAsNetworkService
ECHO #Running,Launching Preparation Client, Please wait...{newline}Starting client as 'NT AUTHORITY\Network Service',true,-1
PsExec -acceptula -i -u "NT AUTHORITY\Network Service" -w "%CD%" "%CD%\Start.bat"
EXIT /B 0