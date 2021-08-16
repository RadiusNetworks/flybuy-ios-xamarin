using ObjCRuntime;

namespace FlyBuy
{
	public enum LocatorEvent : byte
	{
		Confirmed = 1,
		Error = 2,
		Present = 3,
		Received = 4
	}

	[Native]
	public enum PresenceErrorType : long
	{
		InvalidPresenceIdentifierLength = 0,
		InvalidPayloadLength = 1,
		UnableToCreateLocator = 2,
		FailedToStartAdvertising = 3,
		AdvertiserAlreadyStarted = 4,
		LocatorNotStarted = 5,
		BluetoothPoweredOff = 6,
		BluetoothUnauthorized = 7,
		BluetoothUnsupported = 8,
		PresenceManagerNotConfigured = 9
	}
}
