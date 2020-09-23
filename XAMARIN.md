### Create iOS bindings library in Xamarin for FlyBuy

1. In the example Xamarin iOS app, add a new iOS bindings library project named `FlyBuySDK`.

1. Copy `FlyBuy.framework` into the bindings library project directory.

1. In the bindings library project, add a "native reference" to the `FlyBuy.framework`.

1. Install Objective Sharpie

1. Start from the project root directory, the use the following command to find the current iOS SDK version installed.
    ```
    $ sharpie xcode -sdks
    ```

1. Run the following sharpie command (using current SDK version):
    ```
    % sharpie bind --output=FlyBuySDK --namespace=FlyBuy -sdk=iphoneos14.0 FlyBuySDK/FlyBuySDK.framework/Headers/FlyBuySDK-Swift.h -scope FlyBuySDK/FlyBuySDK.framework/Headers
    ```

1. In `ApiDefinition.cs`, delete the "verify" build errors related to `MethodToProperty`.

1. Move the code generated for `CoreOrder_FlyBuy_Swift_218` directly into `CoreOrder`. (This appears to be an artifact from `CoreOrder` being a CoreData entity `NSManagedObject`.)

1. Add Swift class names for each of the FlyBuy `interface`s generated. The Swift class name associated with a class can be found in `FlyBuy.framework/Headers/FlyBuy-Swift.h`. They appear as `SWIFT_CLASS` annotations immediately prior to the associated`@interface` definition.

