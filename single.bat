@echo off
setlocal

REM === Konfigurasi ===
set PROJECT_NAME=rfidx
set PROJECT_PATH=C:\project\rfidx
set CONFIGURATION=Release
set OUTPUT_PATH=%PROJECT_PATH%\bin\%CONFIGURATION%
set NUGET_EXE=nuget.exe
set ILMERGE_PATH=%PROJECT_PATH%\packages\ilmerge.3.0.29\tools\net452\ILMerge.exe
set MERGED_EXE=rfidx-merged.exe

REM === Masuk ke folder project ===
cd /d %PROJECT_PATH%

REM === Unduh nuget.exe jika belum ada ===
if not exist %NUGET_EXE% (
    echo Mengunduh nuget.exe...
    powershell -Command "Invoke-WebRequest https://dist.nuget.org/win-x86-commandline/latest/nuget.exe -OutFile nuget.exe"
)

REM === Install ILMerge (hanya sekali) ===
if not exist "%ILMERGE_PATH%" (
    echo Menginstall ILMerge...
    %NUGET_EXE% install ilmerge -Version 3.0.29 -OutputDirectory packages
)

REM === Build proyek ===
echo Membuild proyek...
msbuild %PROJECT_NAME%.csproj /p:Configuration=%CONFIGURATION%
if errorlevel 1 (
    echo Build gagal.
    exit /b 1
)

REM === Gabungkan file menggunakan ILMerge ===
cd /d %OUTPUT_PATH%
echo Menggabungkan ke file tunggal...
"%ILMERGE_PATH%" /target:winexe /out:%MERGED_EXE% %PROJECT_NAME%.exe *.dll

echo Selesai! File output: %OUTPUT_PATH%\%MERGED_EXE%
pause
