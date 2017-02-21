XBUILD=xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/Quantcast.xcodeproj
TARGET=Quantcast

all: libQuantcast.a

libQuantcast-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libQuantcast-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libQuantcast-armv7s.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libQuantcast-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libQuantcast.a: libQuantcast-i386.a libQuantcast-armv7.a libQuantcast-armv7s.a libQuantcast-arm64.a
	lipo -create -output $@ $^

clean:
	-rm -rf *.a *.dll build/
