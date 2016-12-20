# csherp-test-example

[![Build status](https://ci.appveyor.com/api/projects/status/r2atg1k4l6g1yl0d/branch/master?svg=true)](https://ci.appveyor.com/project/holyshared/csherp-test-example/branch/master)

## Environment

* macOS Sierra
* Visual Studio for Mac

## Setup

	brew install mono

## Build

### Build for Debug

	xbuild ConsoleExample.sln
	xbuild ConsoleExample/ConsoleExample.csproj
	xbuild ConsoleExampleTest/ConsoleExampleTest.csproj

### Build for Release

	xbuild /p:Configuration=Release ConsoleExample.sln
	xbuild /p:Configuration=Release ConsoleExample/ConsoleExample.csproj
	xbuild /p:Configuration=Release ConsoleExampleTest/ConsoleExampleTest.csproj

## Tests

### Tests for Debug

	nunit-console ConsoleExampleTest/bin/Debug/ConsoleExampleTest.dll

### Tests for Release

	nunit-console ConsoleExampleTest/bin/Release/ConsoleExampleTest.dll
