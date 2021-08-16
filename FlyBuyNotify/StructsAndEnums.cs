using ObjCRuntime;

namespace FlyBuy
{
	[Native]
	public enum NotifyErrorType : long
	{
		NoLocationPermission = 0,
		ReachedTheMaxNumberOfSites = 1,
		NotifyModuleNotConfigured = 2
	}
}
