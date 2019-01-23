@ECHO OFF

ECHO Test 1
ECHO 1 key (show help)
ECHO.
ECHO PUTNAME /?
Arch_lab1.exe PUTNAME /?
ECHO Code completion - 0
FOR %%x IN (D:\TestFolder\Test\*) DO SET /a size1+=%%~zx
PAUSE
CLS

ECHO Test 2
ECHO 1 attribute
ECHO.
ECHO PUTNAME D:\TestFolder\ /A:H
Arch_lab1.exe PUTNAME D:\TestFolder\ /A:H
ECHO Code completion - %ErrorLevel%
FOR %%x IN (D:\TestFolder\Test\*) DO SET /a size2+=%%~zx
ECHO Size was %size1% Bytes
ECHO Size is %size2% Bytes
IF %size2% GEQ %size1% ECHO Test OK 
IF NOT %size2% GEQ %size1% ECHO Test WRONG
for %%i in (D:\TestFolder\Test\*) do FIND "2016" %%~fi 
PAUSE
CLS

ECHO Test 3
ECHO 1 mask
ECHO.
ECHO PUTNAME D:\Test\ *.txt
Arch_lab1.exe PUTNAME D:\Test\ *.txt
ECHO Code completion - %ErrorLevel%
FOR %%x IN (D:\utility\ForTest\*) DO SET /a size3+=%%~zx
FOR /R D:\utility\ForTest %%x in (*) DO SET /a size3.1+=%%~zx
ECHO Size was %size2% Bytes
ECHO Size is %size3% Bytes
IF %size3% GEQ %size2% ECHO Test OK 
IF NOT %size3% GEQ %size2% ECHO Test WRONG
PAUSE
CLS

ECHO Test 4
ECHO Recursive search
ECHO.
ECHO PUTNAME D:\utility\ForTest /S
Arch_lab1.exe PUTNAME D:\utility\ForTest /S
ECHO Code completion - %ErrorLevel%
FOR /R D:\utility\ForTest %%x in (*) DO SET /a size4+=%%~zx
ECHO Size was %size3.1% Bytes
ECHO Size is %size4% Bytes
IF %size4% GEQ %size3.1% ECHO Test OK 
IF NOT %size4% GEQ %size3.1% ECHO Test WRONG
for /R D:\utility\ForTest %%i in (*) do FIND "2016" %%~fi 
PAUSE
CLS

ECHO Test 5
ECHO 1 mask, Recursive search
ECHO.
ECHO PUTNAME D:\utility\ForTest /S *.txt
Arch_lab1.exe PUTNAME D:\utility\ForTest /S *.txt
ECHO Code completion - %ErrorLevel%
FOR /R D:\utility\ForTest %%x in (*) DO SET /a size5+=%%~zx
ECHO Size was %size4% Bytes
ECHO Size is %size5% Bytes
IF %size5% GEQ %size4% ECHO Test OK 
IF NOT %size5% GEQ %size4% ECHO Test WRONG
PAUSE
CLS

ECHO Test 6
ECHO 1 masks, 2 attributs, Recursive search
ECHO.
ECHO PUTNAME D:\utility\ForTest /S /A:A-H *.txt
Arch_lab1.exe PUTNAME D:\utility\ForTest /S /A:A-H *.txt
ECHO Code completion - %ErrorLevel%
FOR /R D:\utility\ForTest %%x in (*) DO SET /a size6+=%%~zx
FOR %%x IN (D:\utility\ForTest\*) DO SET /a size6.1+=%%~zx
ECHO Size was %size5% Bytes
ECHO Size is %size6% Bytes
IF %size6% GEQ %size5% ECHO Test OK 
IF NOT %size6% GEQ %size5% ECHO Test WRONG
PAUSE
CLS

ECHO Test 7
ECHO environmental variable
ECHO.
ECHO PUTNAME D:\utility\ForTest
Arch_lab1.exe PUTNAME D:\utility\ForTest
ECHO Code completion - %ErrorLevel%
FOR %%x IN (D:\utility\ForTest\*) DO SET /a size7+=%%~zx
ECHO Size was %size6.1% Bytes
ECHO Size is %size7% Bytes
ECHO.
ECHO exit
ECHO.
Arch_lab1.exe exit
ECHO Code completion - %ErrorLevel%
ECHO.
ECHO set PUTNAMECMD ="/A:H"
set PUTNAMECMD=/A:H
ECHO.
ECHO PUTNAME D:\utility\ForTest
Arch_lab1.exe PUTNAME D:\utility\ForTest
ECHO Code completion - %ErrorLevel%
FOR %%x IN (D:\utility\ForTest\*) DO SET /a size8+=%%~zx
ECHO Size was %size7% Bytes
ECHO Size is %size8% Bytes
IF %size8% GEQ %size7% ECHO Test OK 
IF NOT %size8% GEQ %size7% ECHO Test WRONG
PAUSE
CLS

ECHO Test 8
ECHO Error codes

ECHO.
ECHO 1
ECHO.
ECHO D:\utility\ForTest
Arch_lab1.exe D:\utility\ForTest
ECHO Code completion - %ErrorLevel%
IF %ErrorLevel% == 0 ECHO Test OK
IF NOT %ErrorLevel% == 0 ECHO Test WRONG

ECHO.
ECHO 2
ECHO.
ECHO PUTNAME D:\utility\For
Arch_lab1.exe PUTNAME D:\utility\For
ECHO Code completion - %ErrorLevel%
IF %ErrorLevel% == 0 ECHO Test OK
IF NOT %ErrorLevel% == 0 ECHO Test WRONG

ECHO.
ECHO 3
ECHO.
ECHO PUTNAME D:\utility\ForTest /A:M
Arch_lab1.exe PUTNAME D:\utility\ForTest /A:M
ECHO Code completion - %ErrorLevel%
IF %ErrorLevel% == 0 ECHO Test OK
IF NOT %ErrorLevel% == 0 ECHO Test WRONG

ECHO.
ECHO 4
ECHO.
ECHO PUTNAME D:\utility\ForTest **.mp3
Arch_lab1.exe PUTNAME D:\utility\ForTest **.mp3
ECHO Code completion - %ErrorLevel%
IF %ErrorLevel% == 0 ECHO Test OK
IF NOT %ErrorLevel% == 0 ECHO Test WRONG
PAUSE
CLS