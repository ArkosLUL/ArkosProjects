@ echo off
tasm.exe /l/zi %1
pause
tlink.exe /v %1
pause
td.exe %1
