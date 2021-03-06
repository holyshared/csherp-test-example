# csherp-test-example

[![Build status](https://ci.appveyor.com/api/projects/status/r4fjtv2oe2px8apq/branch/master?svg=true)](https://ci.appveyor.com/project/holyshared/csherp-test-example/branch/master)

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

	xbuild Example.sln
	xbuild ExampleClient/ExampleClient.csproj
	xbuild ExampleClientTest/ExampleClientTest.csproj

### Build for Release

	xbuild /p:Configuration=Release Example.sln
	xbuild /p:Configuration=Release ExampleClient/ExampleClient.csproj
	xbuild /p:Configuration=Release ExampleClientTest/ExampleClientTest.csproj

## Tests

### Tests for Debug

	nunit-console ExampleClientTest/bin/Debug/ExampleClientTest.dll

### Tests for Release

	nunit-console ExampleClientTest/bin/Release/ExampleClientTest.dll

## Packaging for NuGet

### Without symbol package

	mono ~/bin/nuget.exe pack ExampleClient/ExampleClient.csproj -properties Configuration=Release -outputdirectory .

### With symbol package

	mono ~/bin/nuget.exe pack ExampleClient/ExampleClient.csproj -symbols -properties Configuration=Release -outputdirectory .
