# csherp-test-example

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
