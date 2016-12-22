# csherp-test-example

[![Build status](https://ci.appveyor.com/api/projects/status/r2atg1k4l6g1yl0d/branch/master?svg=true)](https://ci.appveyor.com/project/holyshared/csherp-test-example/branch/master)

## Environment

* macOS Sierra
* Visual Studio for Mac

## Setup

### Install Mono Framework

	brew install mono

### Install NuGet

	mkdir ~/bin
	cd bin
	wget https://dist.nuget.org/win-x86-commandline/latest/nuget.exe

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

## Packaging for NuGet

	mono ~/bin/nuget.exe pack ConsoleExample/ConsoleExample.csproj -properties Configuration=Release -outputdirectory .
