set CSC=
set OPT=

if EXIST C:\Windows\Microsoft.NET\Framework64\v2.0.50727\csc.exe (
    set CSC=C:\Windows\Microsoft.NET\Framework64\v2.0.50727\csc.exe
    set OPT=
)

%CSC% %OPT% /target:winexe /win32icon:WhiteBackground\app.ico /out:WhiteBackground.exe WhiteBackground\*.cs
pause
