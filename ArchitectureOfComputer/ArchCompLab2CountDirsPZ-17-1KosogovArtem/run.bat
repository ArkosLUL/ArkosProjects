@ECHO OFF

ECHO Test #0:
ECHO Help command
Count.py -h
PAUSE
CLS

ECHO Test #1:
ECHO Command with directory key -D
for /D %%i in (.\Test\*) do set /a l+=1
ECHO %l%
Count.py -D .\Test\
IF %ErrorLevel% == %l% ECHO Test Ok
IF NOT %ErrorLevel% == %l% ECHO Test Wrong :(
PAUSE
CLS

ECHO Test #2:
ECHO Command with two keys: -D -R
Set /a l=0
FOR /R .\Test\ /D %%i in (*) do set /a l+=1
ECHO %l%
Count.py -D .\Test -R
IF %ErrorLevel% == %l% ECHO Test Ok
IF NOT %ErrorLevel% == %l% ECHO Test Wrong :(
PAUSE
CLS

ECHO Test #3:
ECHO Command without parametrs
Set /a l=0
FOR /D %%i in (.\*) do set /a l+=1
ECHO %l%
Count.py
IF %ErrorLevel% == %l% ECHO Test Ok
IF NOT %ErrorLevel% == %l% ECHO Test Wrong :(
PAUSE
CLS

ECHO Test #4:
ECHO Command with environment variable
Set /a l=0
FOR /D %%i in (.\Test\Test1\*) do set /a l+=1
set PATHCMD=./Test/Test1
ECHO %l%
Count.py
IF %ErrorLevel% == %l% ECHO Test Ok
IF NOT %ErrorLevel% == %l% ECHO Test Wrong :(
PAUSE
CLS

ECHO Test #5:
ECHO Command with environment variable and key -R
Set /a l=0
FOR /R .\Test\Test1 /D %%i in (*) do set /a l+=1
ECHO %l%
Count.py -R
IF %ErrorLevel% == %l% ECHO Test Ok
IF NOT %ErrorLevel% == %l% ECHO Test Wrong :(
PAUSE
CLS