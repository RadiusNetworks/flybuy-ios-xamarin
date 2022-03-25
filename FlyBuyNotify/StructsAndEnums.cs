using ObjCRuntime;

namespace FlyBuy
{
	[Native]
	public enum NotifyErrorType : long
	{
		NoLocationPermission = 0,
		ReachedTheMaxNumberOfSites = 1,
		NotifyModuleNotConfigured = 2,
		CoreIsNotConfigured = 3,
		NotifyModuleNotEnabled = 4,
		BeaconRangingNotAvailable = 5,
		NoBeaconInRange = 6,
		BeaconRangingDisabledInBackground = 7
	}
}
