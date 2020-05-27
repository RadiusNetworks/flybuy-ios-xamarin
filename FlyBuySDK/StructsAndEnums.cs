using ObjCRuntime;

namespace FlyBuy
{
	[Native]
	public enum CustomerState : long
	{
		Created = 0,
		EnRoute = 1,
		Nearby = 2,
		Arrived = 3,
		Waiting = 4,
		Completed = 5
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
	public enum OrderState : long
	{
		Created = 0,
		Ready = 1,
		Delayed = 2,
		Cancelled = 3,
		Completed = 4,
		Gone = 5
	}
}
