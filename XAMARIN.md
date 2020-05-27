### Create iOS bindings library in Xamarin for FlyBuy

1. In the example Xamarin iOS app, add a new iOS bindings library project named `FlyBuySDK`.

1. Copy `FlyBuy.framework` into the bindings library project directory.

1. In the bindings library project, add a "native reference" to the `FlyBuy.framework`.

1. Install Objective Sharpie

1. Change directory to the directory containing `FlyBuy.framework`, preferably a copy outside of the Xamarin project directory.

1. Run the following sharpie command:
    ```
    $ sharpie bind --output=FlyBuySDK --namespace=FlyBuy --sdk=iphoneos12.2 ./FlyBuy.framework/Headers/FlyBuy-Swift.h -scope ./FlyBuy.framework/Headers
    ```

1. Copy the generated files `ApiDefinitions.cs` and `StructsAndEnums.cs` into the binding library’s directory to replace the default `ApiDefinition.cs` and `Structs.cs` files.

1. In `Structs.cs`, change `nint` to `long`.

1. In `ApiDefinition.cs`, delete the "verify" build errors related to `MethodToProperty`.

1. Move the code generated for `CoreOrder_FlyBuy_Swift_218` directly into `CoreOrder`. (This appears to be an artifact from `CoreOrder` being a CoreData entity `NSManagedObject`.)

1. Add Swift class names for each of the FlyBuy `interface`s generated. The Swift class name associated with a class can be found in `FlyBuy.framework/Headers/FlyBuy-Swift.h`. They appear as `SWIFT_CLASS` annotations immediately prior to the associated`@interface` definition.

