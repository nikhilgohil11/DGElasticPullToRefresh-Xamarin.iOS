XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=./
PROJECT=$(PROJECT_ROOT)/DGElasticPullToRefreshStatic.xcodeproj
TARGET=DGElasticPullToRefreshStatic

all: libDGElasticPullToRefreshUniversal.a

libDGElasticPullToRefresh-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libDGElasticPullToRefresh-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libDGElasticPullToRefresh-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libDGElasticPullToRefresh-armv7s.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libDGElasticPullToRefreshUniversal.a: libDGElasticPullToRefresh-i386.a libDGElasticPullToRefresh-armv7.a libDGElasticPullToRefresh-armv7s.a libDGElasticPullToRefresh-arm64.a
	lipo -create -output $@ $^

clean:
	-rm -f *.a *.dll