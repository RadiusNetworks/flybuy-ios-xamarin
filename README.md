# FlyBuy SDK for Xamarin.iOS
Last updated 26-May-2020

### Nuget

This is available on nuget.org here: https://www.nuget.org/packages/Radiusnetworks.Flybuy.IOS/

### Add FlyBuySDK to your Xamarin.iOS project

In order to use `FlyBuy` from a Xamarin.iOS project, you need to add the FlyBuySDK bindings library to your Xamarin.iOS solution

1. Unzip the FlyBuy SDK bindings library project in your solution root directory.
2. In your solution in Visual Studio, right-click on your solution and choose `Add -> Add Existing Project…`.
3. In the `FlyBuySDK` directory, choose the file `FlyBuySDK.csproj` and click `Open`.

### Add a Reference to the FlyBuySDK bindings library

1. In your app project, right-click on `References` and choose `Edit References…`.
2. Click on the `Projects` tab, then check `FlyBuySDK`.
3. Now you can add the following to any C# files in your app where you want to use classes from `FlyBuySDK`:

