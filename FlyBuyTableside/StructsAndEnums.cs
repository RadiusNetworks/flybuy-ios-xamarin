using ObjCRuntime;

namespace FlyBuy
{
	[Native]
	public enum FlyBuyAPIErrorType : long
	{
		InvalidResponse = 0,
		ResponseError = 1
	}

	[Native]
	public enum TablesideErrorType : long
	{
		InvalidPayloadLength = 0,
		UnableToCreateLocator = 1,
		FailedToStartAdvertising = 2,
		AdvertiserAlreadyStarted = 3,
		LocatorNotStarted = 4,
		BluetoothPoweredOff = 5,
		BluetoothUnauthorized = 6,
		BluetoothUnsupported = 7,
		TablesideManagerNotConfigured = 8,
		NeedsLocationUsageKeys = 9,
		LocationPermissionInsufficient = 10
	}

	[Native]
	public enum TablesideLogLevel : long
	{
		Verbose = 0,
		Debug = 1,
		Info = 2,
		Warning = 3,
		Error = 4,
		None = 5
	}

	[Native]
	public enum TablesideSiteEvent : long
	{
		ntered = 0,
		xited = 1
	}
}
