BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild
VERSION=1.8.1

all: Quantcast.dll

Quantcast.dll: Makefile ApiDefinition.cs libQuantcast.a
	$(MONOXBUILD) /p:Configuration=Release Quantcast.csproj
	cp bin/Release/Quantcast.dll Quantcast.dll

clean:
	-rm -rf list ios *.dll *.zip *.mdb *.sln bin/ obj/
