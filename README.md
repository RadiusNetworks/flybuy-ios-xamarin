# FlyBuy SDK for Xamarin.iOS

### Nuget

The FlyBuy SDK is published on nuget.org at the following location: https://www.nuget.org/packages/Radiusnetworks.Flybuy.IOS

### Add FlyBuySDK to your Xamarin.iOS project

Select `Packages` in your VS project and go to `Manage NuGet Packages...`. Search for `Radiusnetworks.Flybuy.IOS` and click `Add Package`. The latest SDK will be added to your project and can be referenced with the following:
```
using FlyBuy;
```

## Creating iOS bindings library in Xamarin for FlyBuy

1. Download the latest native SDK release from https://github.com/RadiusNetworks/flybuy-ios/releases

1. Unzip the archive and copy the `xcframework` directories for each module to their related directories. E.G.
    ```
    flybuy-ios-2.1.5/FlyBuyPickup.xcframework --> FlyBuyPickup
    ```

1. Select _Native References_ in the VS project for each module and add the related `framework` for the `ios-arm64` binary.

1. Install Objective Sharpie to generate the binding API definitions.

1. Start from the project root directory, the use the following command to find the current iOS SDK version installed.
    ```
    sharpie xcode -sdks
    ```

1. Run the following sharpie commands (using current iOS SDK version):
    ```
    sharpie bind --output=FlyBuy --namespace=FlyBuy -framework FlyBuy/FlyBuy.xcframework/ios-arm64/FlyBuy.framework -sdk=iphoneos14.4
    ```

    ```
    sharpie bind --output=FlyBuyPickup --namespace=FlyBuy -framework FlyBuyPickup/FlyBuyPickup.xcframework/ios-arm64/FlyBuyPickup.framework -sdk=iphoneos14.4
    ```

    ```
    sharpie bind --output=FlyBuyNotify --namespace=FlyBuy -framework FlyBuyNotify/FlyBuyNotify.xcframework/ios-arm64/FlyBuyNotify.framework -sdk=iphoneos14.4
    ```

    ```
    sharpie bind --output=FlyBuyPresence --namespace=FlyBuy -framework FlyBuyPresence/FlyBuyPresence.xcframework/ios-arm64/FlyBuyPresence.framework -sdk=iphoneos14.4
    ```

1. In `ApiDefinitions.cs`, delete the "verify" build errors related to `MethodToProperty`.

1. The bindings project will now reference the new `xcframework` and API definition files and can be built.

