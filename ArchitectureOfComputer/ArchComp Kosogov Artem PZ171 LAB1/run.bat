@ECHO OFF

ECHO Test 1
ECHO 1 key (show help)
ECHO.
ECHO PUTNAME /?
Arch_lab1.exe PUTNAME /?

IF %ErrorLevel% == 3 ECHO Test OK 
IF NOT %ErrorLevel% == 3 ECHO Test WRONG
FOR %%x IN (.\TestFolder\Test\*) DO SET /a size1+=%%~zx
PAUSE
CLS

ECHO Test 2
ECHO 1 attribute
ECHO.
ECHO PUTNAME ./TestFolder/Test/ /A:AR
Arch_lab1.exe PUTNAME ./TestFolder/Test/ /A:AR

FOR %%x IN (.\TestFolder\Test\*) DO SET /a size2+=%%~zx
IF %size2% GEQ %size1% ECHO Test OK 
IF NOT %size2% GEQ %size1% ECHO Test WRONG
PAUSE
CLS

ECHO Test 3
ECHO 1 mask
ECHO.
ECHO PUTNAME ./TestFolder/Test/ *.txt
Arch_lab1.exe PUTNAME ./TestFolder/Test/ *.txt

FOR %%x IN (.\TestFolder\Test\*) DO SET /a size3+=%%~zx
FOR /R .\TestFolder\Test\ %%x in (*) DO SET /a size3.1+=%%~zx
IF %size3% GEQ %size2% ECHO Test OK 
IF NOT %size3% GEQ %size2% ECHO Test WRONG
PAUSE
CLS

ECHO Test 4
ECHO Recursive search
ECHO.
ECHO PUTNAME ./TestFolder/ /S
Arch_lab1.exe PUTNAME ./TestFolder/ /S

FOR /R .\TestFolder\ %%x in (*) DO SET /a size4+=%%~zx
IF %size4% GEQ %size3.1% ECHO Test OK 
IF NOT %size4% GEQ %size3.1% ECHO Test WRONG 
PAUSE
CLS

ECHO Test 5
ECHO 1 mask, Recursive search
ECHO.
ECHO PUTNAME ./TestFolder/ /S *.txt
Arch_lab1.exe PUTNAME ./TestFolder/ /S *.txt

FOR /R .\TestFolder\ %%x in (*) DO SET /a size5+=%%~zx
IF %size5% GEQ %size4% ECHO Test OK 
IF NOT %size5% GEQ %size4% ECHO Test WRONG
PAUSE
CLS

ECHO Test 6
ECHO 1 masks, 2 attributs, Recursive search
ECHO.
ECHO PUTNAME ./TestFolder/ /S /A:AR *.txt
Arch_lab1.exe PUTNAME ./TestFolder/ /S /A:AR *.txt

FOR /R .\TestFolder\ %%x in (*) DO SET /a size6+=%%~zx
FOR %%x IN (.\TestFolder\*) DO SET /a size6.1+=%%~zx
IF %size6% GEQ %size5% ECHO Test OK 
IF NOT %size6% GEQ %size5% ECHO Test WRONG
PAUSE
CLS

ECHO Test 7
ECHO environmental variable
ECHO.
ECHO PUTNAME ./TestFolder/Test/
Arch_lab1.exe PUTNAME ./TestFolder/Test/

FOR %%x IN (.\TestFolder\Test\*) DO SET /a size7+=%%~zx
ECHO.
ECHO exit
ECHO.
Arch_lab1.exe exit

ECHO.
ECHO set PUTNAMECMD ="/A:-S"
set PUTNAMECMD=/A:H
ECHO.
ECHO PUTNAME ./TestFolder/Test/
Arch_lab1.exe PUTNAME ./TestFolder/Test/

FOR %%x IN (.\TestFolder\Test\*) DO SET /a size8+=%%~zx
IF %size8% GEQ %size7% ECHO Test OK 
IF NOT %size8% GEQ %size7% ECHO Test WRONG
PAUSE
CLS

ECHO Test 8
ECHO Error codes

ECHO.
ECHO 1
ECHO.
ECHO ./TestFolder/Test/
Arch_lab1.exe ./TestFolder/Test/

IF %ErrorLevel% == 2 ECHO Test OK
IF NOT %ErrorLevel% == 2 ECHO Test WRONG


ECHO.
ECHO 2
ECHO.
ECHO PUTNAME ./TestFolder/Test/ /A:M
Arch_lab1.exe PUTNAME ./TestFolder/Test/ /A:M

IF %ErrorLevel% == 4 ECHO Test OK
IF NOT %ErrorLevel% == 4 ECHO Test WRONG

ECHO.
ECHO 3
ECHO.
ECHO PUTNAME ./TestFolder/Test/ **.mp3
Arch_lab1.exe PUTNAME ./TestFolder/Test/ **.mp3

IF %ErrorLevel% == 5 ECHO Test OK
IF NOT %ErrorLevel% == 5 ECHO Test WRONG
PAUSE
CLS