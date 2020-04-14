# assumes the following paths for csc and ildasm
$csc = "${Env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\Roslyn\csc.exe"
$ildasm = "${Env:ProgramFiles(x86)}\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\ildasm.exe"

# build the programs
& $csc /out:linq-person.exe /t:exe linq-person.cs
& $csc /out:foreach-person.exe /t:exe foreach-person.cs

# disassemble the programs
& $ildasm /html /out=linq-person.html linq-person.exe
& $ildasm /html /out=foreach-person.html foreach-person.exe