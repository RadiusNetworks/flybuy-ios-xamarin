### Create iOS bindings library in Xamarin for FlyBuy

1. In the example Xamarin iOS app, add a new iOS bindings library project named `FlyBuySDK`.

1. Copy `FlyBuy.framework` into the bindings library project directory.

1. In the bindings library project, add a "native reference" to the `FlyBuy.framework`.

1. Install Objective Sharpie

1. Start from the project root directory, the use the following command to find the current iOS SDK version installed.
    ```
    $ sharpie xcode -sdks
    ```

1. Run the following sharpie commands (using current iOS SDK version):
```
flybuy-ios-xamarin % sharpie bind --output=FlyBuy --namespace=FlyBuy -framework FlyBuy/FlyBuy.xcframework/ios-arm64/FlyBuy.framework -sdk=iphoneos14.4
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

