@ echo off
tasm.exe /l/zi lab1.asm
pause
tlink.exe /v lab1.obj
pause
td.exe lab1.exe
