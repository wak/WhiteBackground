set CSC=
set OPT=

if EXIST C:\Windows\Microsoft.NET\Framework64\v2.0.50727\csc.exe (
    set CSC=C:\Windows\Microsoft.NET\Framework64\v2.0.50727\csc.exe
    set OPT=
)

if EXIST C:\Windows\Microsoft.NET\Framework64\v3.5\csc.exe (
    set CSC=C:\Windows\Microsoft.NET\Framework64\v3.5\csc.exe
    set OPT=/win32manifest:WhiteBackground\app.manifest
)

if EXIST C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe (
    set CSC=C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe
    set OPT=/win32manifest:WhiteBackground\app.manifest
)

%CSC% %OPT% /target:winexe /win32icon:WhiteBackground\app.ico /out:WhiteBackground.exe WhiteBackground\*.cs
pause
