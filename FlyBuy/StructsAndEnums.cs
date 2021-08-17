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
	public enum LocationAuthStatus : long
	{
		NotDetermined = 0,
		Restricted = 1,
		Denied = 2,
		AuthorizedAlways = 3,
		AuthorizedWhenInUse = 4
	}

	[Native]
	public enum LogLevel : long
	{
		Verbose = 0,
		Debug = 1,
		Info = 2,
		Warning = 3,
		Error = 4,
		None = 5
	}
}
