path = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\Roslyn\"

cls
csc.exe /target:library "033 Library.cs"
csc.exe /target:exe /r:"033 Library.dll" "033 CallFromLibrary.cs"
