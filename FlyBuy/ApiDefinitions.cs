using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace FlyBuy
{
	[Static]
	partial interface Constants
	{
		// extern double FlyBuyVersionNumber;
		[Field ("FlyBuyVersionNumber", "__Internal")]
		double FlyBuyVersionNumber { get; }

		// extern const unsigned char [] FlyBuyVersionString;
		[Field ("FlyBuyVersionString", "__Internal")]
		NSString FlyBuyVersionString { get; }
	}

	// @interface AppUpgrade : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy10AppUpgrade")]
	interface AppUpgrade
	{
	}

	// @interface FlyBuyBeaconList : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuyBeaconList
	{
	}

	// @interface FlyBuyClaimOrderInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyClaimOrderInfo
	{
		// -(instancetype _Nonnull)initWithCustomerCarColor:(NSString * _Nullable)customerCarColor customerCarType:(NSString * _Nullable)customerCarType customerLicensePlate:(NSString * _Nullable)customerLicensePlate customerName:(NSString * _Nullable)customerName customerPhone:(NSString * _Nullable)customerPhone pushToken:(NSString * _Nonnull)pushToken __attribute__((objc_designated_initializer));
		[Export ("initWithCustomerCarColor:customerCarType:customerLicensePlate:customerName:customerPhone:pushToken:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string customerCarColor, [NullAllowed] string customerCarType, [NullAllowed] string customerLicensePlate, [NullAllowed] string customerName, [NullAllowed] string customerPhone, string pushToken);

		// -(instancetype _Nonnull)initWithCustomerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pushToken:(NSString * _Nonnull)pushToken pickupType:(NSString * _Nullable)pickupType __attribute__((objc_designated_initializer));
		[Export ("initWithCustomerInfo:pushToken:pickupType:")]
		[DesignatedInitializer]
		IntPtr Constructor (FlyBuyCustomerInfo customerInfo, string pushToken, [NullAllowed] string pickupType);
	}

	// @interface FlyBuyConfigurationManager : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuyConfigurationManager
	{
	}

	// @interface FlyBuyCore : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyCore
	{
		// @property (readonly, nonatomic, strong, class) FlyBuyOrdersManager * _Nonnull orders;
		[Static]
		[Export ("orders", ArgumentSemantic.Strong)]
		FlyBuyOrdersManager Orders { get; }

		// @property (readonly, nonatomic, strong, class) FlyBuyCustomerManager * _Nonnull customer;
		[Static]
		[Export ("customer", ArgumentSemantic.Strong)]
		FlyBuyCustomerManager Customer { get; }

		// @property (readonly, nonatomic, strong, class) FlyBuySitesManager * _Nonnull sites;
		[Static]
		[Export ("sites", ArgumentSemantic.Strong)]
		FlyBuySitesManager Sites { get; }

		// @property (readonly, nonatomic, strong, class) FlyBuyConfigurationManager * _Nonnull config;
		[Static]
		[Export ("config", ArgumentSemantic.Strong)]
		FlyBuyConfigurationManager Config { get; }

		// @property (readonly, nonatomic, strong, class) FlyBuyLogger * _Nonnull logger;
		[Static]
		[Export ("logger", ArgumentSemantic.Strong)]
		FlyBuyLogger Logger { get; }

		// +(void)configure:(NSDictionary<NSString *,id> * _Nonnull)opts;
		[Static]
		[Export ("configure:")]
		void Configure (NSDictionary<NSString, NSObject> opts);

		// +(void)handleRemoteNotification:(NSDictionary * _Nonnull)data;
		[Static]
		[Export ("handleRemoteNotification:")]
		void HandleRemoteNotification (NSDictionary data);

		// +(void)updatePushToken:(NSString * _Nonnull)newPushToken;
		[Static]
		[Export ("updatePushToken:")]
		void UpdatePushToken (string newPushToken);

		// +(void)updateAPNPushToken:(NSData * _Nonnull)deviceToken;
		[Static]
		[Export ("updateAPNPushToken:")]
		void UpdateAPNPushToken (NSData deviceToken);
	}

	// @interface FlyBuyCreateOrderInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyCreateOrderInfo
	{
		// -(instancetype _Nonnull)initWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerCarColor:(NSString * _Nullable)customerCarColor customerCarType:(NSString * _Nullable)customerCarType customerLicensePlate:(NSString * _Nullable)customerLicensePlate customerName:(NSString * _Nullable)customerName customerPhone:(NSString * _Nullable)customerPhone pushToken:(NSString * _Nullable)pushToken state:(NSString * _Nullable)state pickupWindow:(FlyBuyPickupWindow * _Nullable)pickupWindow __attribute__((objc_designated_initializer));
		[Export ("initWithSiteID:partnerIdentifier:customerCarColor:customerCarType:customerLicensePlate:customerName:customerPhone:pushToken:state:pickupWindow:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint siteID, string partnerIdentifier, [NullAllowed] string customerCarColor, [NullAllowed] string customerCarType, [NullAllowed] string customerLicensePlate, [NullAllowed] string customerName, [NullAllowed] string customerPhone, [NullAllowed] string pushToken, [NullAllowed] string state, [NullAllowed] FlyBuyPickupWindow pickupWindow);

		// -(instancetype _Nonnull)initWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerCarColor:(NSString * _Nullable)customerCarColor customerCarType:(NSString * _Nullable)customerCarType customerLicensePlate:(NSString * _Nullable)customerLicensePlate customerName:(NSString * _Nullable)customerName customerPhone:(NSString * _Nullable)customerPhone pushToken:(NSString * _Nullable)pushToken pickupWindow:(FlyBuyPickupWindow * _Nullable)pickupWindow __attribute__((objc_designated_initializer));
		[Export ("initWithSiteID:partnerIdentifier:customerCarColor:customerCarType:customerLicensePlate:customerName:customerPhone:pushToken:pickupWindow:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint siteID, string partnerIdentifier, [NullAllowed] string customerCarColor, [NullAllowed] string customerCarType, [NullAllowed] string customerLicensePlate, [NullAllowed] string customerName, [NullAllowed] string customerPhone, [NullAllowed] string pushToken, [NullAllowed] FlyBuyPickupWindow pickupWindow);
	}

	// @interface FlyBuyCustomer : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyCustomer
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull token;
		[Export ("token")]
		string Token { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable emailAddress;
		[NullAllowed, Export ("emailAddress")]
		string EmailAddress { get; }

		// @property (readonly, nonatomic, strong) FlyBuyCustomerInfo * _Nonnull info;
		[Export ("info", ArgumentSemantic.Strong)]
		FlyBuyCustomerInfo Info { get; }

		// @property (readonly, nonatomic) BOOL registered;
		[Export ("registered")]
		bool Registered { get; }
	}

	// @interface FlyBuyCustomerConsent : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyCustomerConsent
	{
		// @property (readonly, nonatomic) BOOL termsOfService;
		[Export ("termsOfService")]
		bool TermsOfService { get; }

		// @property (readonly, nonatomic) BOOL ageVerification;
		[Export ("ageVerification")]
		bool AgeVerification { get; }

		// -(instancetype _Nonnull)initWithTermsOfService:(BOOL)termsOfService ageVerification:(BOOL)ageVerification __attribute__((objc_designated_initializer));
		[Export ("initWithTermsOfService:ageVerification:")]
		[DesignatedInitializer]
		IntPtr Constructor (bool termsOfService, bool ageVerification);
	}

	// @interface FlyBuyCustomerInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyCustomerInfo
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable carType;
		[NullAllowed, Export ("carType")]
		string CarType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable carColor;
		[NullAllowed, Export ("carColor")]
		string CarColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable licensePlate;
		[NullAllowed, Export ("licensePlate")]
		string LicensePlate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name carType:(NSString * _Nullable)carType carColor:(NSString * _Nullable)carColor licensePlate:(NSString * _Nullable)licensePlate phone:(NSString * _Nullable)phone __attribute__((objc_designated_initializer));
		[Export ("initWithName:carType:carColor:licensePlate:phone:")]
		[DesignatedInitializer]
		IntPtr Constructor (string name, [NullAllowed] string carType, [NullAllowed] string carColor, [NullAllowed] string licensePlate, [NullAllowed] string phone);
	}

	// @interface FlyBuyCustomerManager : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuyCustomerManager
	{
		// @property (readonly, nonatomic, strong) FlyBuyCustomer * _Nullable current;
		[NullAllowed, Export ("current", ArgumentSemantic.Strong)]
		FlyBuyCustomer Current { get; }

		// -(void)create:(FlyBuyCustomerInfo * _Nonnull)customerInfo termsOfService:(BOOL)termsOfService ageVerification:(BOOL)ageVerification callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("create:termsOfService:ageVerification:callback:")]
		void Create (FlyBuyCustomerInfo customerInfo, bool termsOfService, bool ageVerification, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)create:(FlyBuyCustomerInfo * _Nonnull)customerInfo email:(NSString * _Nonnull)email password:(NSString * _Nonnull)password customerConsent:(FlyBuyCustomerConsent * _Nonnull)customerConsent callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("create:email:password:customerConsent:callback:")]
		void Create (FlyBuyCustomerInfo customerInfo, string email, string password, FlyBuyCustomerConsent customerConsent, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)update:(FlyBuyCustomerInfo * _Nonnull)customerInfo callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("update:callback:")]
		void Update (FlyBuyCustomerInfo customerInfo, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)loginWithEmailAddress:(NSString * _Nonnull)emailAddress password:(NSString * _Nonnull)password callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("loginWithEmailAddress:password:callback:")]
		void LoginWithEmailAddress (string emailAddress, string password, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)loginWithTokenWithToken:(NSString * _Nonnull)token callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("loginWithTokenWithToken:callback:")]
		void LoginWithTokenWithToken (string token, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)signUpWithEmailAddress:(NSString * _Nonnull)emailAddress password:(NSString * _Nonnull)password callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("signUpWithEmailAddress:password:callback:")]
		void SignUpWithEmailAddress (string emailAddress, string password, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)requestNewPasswordWithEmailAddress:(NSString * _Nonnull)emailAddress callback:(void (^ _Nullable)(NSError * _Nullable))callback;
		[Export ("requestNewPasswordWithEmailAddress:callback:")]
		void RequestNewPasswordWithEmailAddress (string emailAddress, [NullAllowed] Action<NSError> callback);

		// -(void)setNewPasswordWithResetPasswordToken:(NSString * _Nonnull)resetPasswordToken password:(NSString * _Nonnull)password confirmation:(NSString * _Nonnull)confirmation callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("setNewPasswordWithResetPasswordToken:password:confirmation:callback:")]
		void SetNewPasswordWithResetPasswordToken (string resetPasswordToken, string password, string confirmation, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)logout;
		[Export ("logout")]
		void Logout ();
	}

	// @interface FlyBuyCustomerManagerError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyCustomerManagerError
	{
	}

	// @interface FlyBuyAPIError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyAPIError
	{
		// @property (readonly, nonatomic) enum FlyBuyAPIErrorType type;
		[Export ("type")]
		FlyBuyAPIErrorType Type { get; }

		// @property (readonly, nonatomic) NSInteger statusCodeInt;
		[Export ("statusCodeInt")]
		nint StatusCodeInt { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface FlyBuyGeofence : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuyGeofence
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull latitude;
		[Export ("latitude")]
		string Latitude { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull longitude;
		[Export ("longitude")]
		string Longitude { get; }

		// @property (readonly, nonatomic) double radiusMeters;
		[Export ("radiusMeters")]
		double RadiusMeters { get; }
	}

	// @interface FlyBuyLogger : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyLogger
	{
	}

	// @interface FlyBuyLoginInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyLoginInfo
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull emailAddress;
		[Export ("emailAddress")]
		string EmailAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull password;
		[Export ("password")]
		string Password { get; }

		// -(instancetype _Nonnull)initWithEmailAddress:(NSString * _Nonnull)emailAddress password:(NSString * _Nonnull)password __attribute__((objc_designated_initializer));
		[Export ("initWithEmailAddress:password:")]
		[DesignatedInitializer]
		IntPtr Constructor (string emailAddress, string password);
	}

	// @interface FlyBuyOrder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyOrder : INativeObject
	{
		// @property (readonly, nonatomic) NSInteger id;
		[Export ("id")]
		nint Id { get; }

		// @property (readonly, nonatomic) NSInteger siteID;
		[Export ("siteID")]
		nint SiteID { get; }

		// @property (copy, nonatomic) NSString * _Nonnull state;
		[Export ("state")]
		string State { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull customerState;
		[Export ("customerState")]
		string CustomerState { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable partnerIdentifier;
		[NullAllowed, Export ("partnerIdentifier")]
		string PartnerIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable redemptionCode;
		[NullAllowed, Export ("redemptionCode")]
		string RedemptionCode { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable redeemedAt;
		[NullAllowed, Export ("redeemedAt", ArgumentSemantic.Copy)]
		NSDate RedeemedAt { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable displayName;
		[NullAllowed, Export ("displayName")]
		string DisplayName { get; }

		// @property (readonly, nonatomic, strong) FlyBuyPickupWindow * _Nullable pickupWindow;
		[NullAllowed, Export ("pickupWindow", ArgumentSemantic.Strong)]
		FlyBuyPickupWindow PickupWindow { get; }

		// @property (copy, nonatomic) NSString * _Nullable pickupType;
		[NullAllowed, Export ("pickupType")]
		string PickupType { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable etaAt;
		[NullAllowed, Export ("etaAt", ArgumentSemantic.Copy)]
		NSDate EtaAt { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable completedAt;
		[NullAllowed, Export ("completedAt", ArgumentSemantic.Copy)]
		NSDate CompletedAt { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt", ArgumentSemantic.Copy)]
		NSDate CreatedAt { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable updatedAt;
		[NullAllowed, Export ("updatedAt", ArgumentSemantic.Copy)]
		NSDate UpdatedAt { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable customerRating;
		[NullAllowed, Export ("customerRating")]
		string CustomerRating { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable customerComment;
		[NullAllowed, Export ("customerComment")]
		string CustomerComment { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteName;
		[NullAllowed, Export ("siteName")]
		string SiteName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sitePhone;
		[NullAllowed, Export ("sitePhone")]
		string SitePhone { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteStreetAddress;
		[NullAllowed, Export ("siteStreetAddress")]
		string SiteStreetAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteFullAddress;
		[NullAllowed, Export ("siteFullAddress")]
		string SiteFullAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteLocality;
		[NullAllowed, Export ("siteLocality")]
		string SiteLocality { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteRegion;
		[NullAllowed, Export ("siteRegion")]
		string SiteRegion { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteCountry;
		[NullAllowed, Export ("siteCountry")]
		string SiteCountry { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sitePostalCode;
		[NullAllowed, Export ("sitePostalCode")]
		string SitePostalCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteLongitude;
		[NullAllowed, Export ("siteLongitude")]
		string SiteLongitude { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteLatitude;
		[NullAllowed, Export ("siteLatitude")]
		string SiteLatitude { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteInstructions;
		[NullAllowed, Export ("siteInstructions")]
		string SiteInstructions { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteDescription;
		[NullAllowed, Export ("siteDescription")]
		string SiteDescription { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteCoverPhotoURL;
		[NullAllowed, Export ("siteCoverPhotoURL")]
		string SiteCoverPhotoURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sitePartnerIdentifier;
		[NullAllowed, Export ("sitePartnerIdentifier")]
		string SitePartnerIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable projectAccentColor;
		[NullAllowed, Export ("projectAccentColor")]
		string ProjectAccentColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable projectAccentTextColor;
		[NullAllowed, Export ("projectAccentTextColor")]
		string ProjectAccentTextColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable projectLogoURL;
		[NullAllowed, Export ("projectLogoURL")]
		string ProjectLogoURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerName;
		[NullAllowed, Export ("customerName")]
		string CustomerName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerCarType;
		[NullAllowed, Export ("customerCarType")]
		string CustomerCarType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerCarColor;
		[NullAllowed, Export ("customerCarColor")]
		string CustomerCarColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerLicensePlate;
		[NullAllowed, Export ("customerLicensePlate")]
		string CustomerLicensePlate { get; }

		// @property (readonly, nonatomic) BOOL projectMobileFlowAlwaysShowVehicleInfoFields;
		[Export ("projectMobileFlowAlwaysShowVehicleInfoFields")]
		bool ProjectMobileFlowAlwaysShowVehicleInfoFields { get; }

		// @property (readonly, nonatomic) BOOL projectMobileFlowCustomerNameEditingEnabled;
		[Export ("projectMobileFlowCustomerNameEditingEnabled")]
		bool ProjectMobileFlowCustomerNameEditingEnabled { get; }

		// @property (readonly, nonatomic) BOOL projectMobileFlowPickupTypeSelectionEnabled;
		[Export ("projectMobileFlowPickupTypeSelectionEnabled")]
		bool ProjectMobileFlowPickupTypeSelectionEnabled { get; }

		// @property (readonly, nonatomic) BOOL projectMobileFlowRequireVehicleInfoIfVisible;
		[Export ("projectMobileFlowRequireVehicleInfoIfVisible")]
		bool ProjectMobileFlowRequireVehicleInfoIfVisible { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable curbsideLocalizedString;
		[NullAllowed, Export ("curbsideLocalizedString")]
		string CurbsideLocalizedString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable pickupLocalizedString;
		[NullAllowed, Export ("pickupLocalizedString")]
		string PickupLocalizedString { get; }

		// @property (copy, nonatomic) NSString * _Nullable pushToken;
		[NullAllowed, Export ("pushToken")]
		string PushToken { get; set; }

		// -(CLLocation * _Nullable)siteLocation __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("siteLocation")]
		CLLocation SiteLocation { get; }

		// -(NSNumber * _Nullable)siteDistanceFrom:(CLLocation * _Nonnull)location __attribute__((warn_unused_result("")));
		[Export ("siteDistanceFrom:")]
		[return: NullAllowed]
		NSNumber SiteDistanceFrom (CLLocation location);

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable customerID;
		[NullAllowed, Export ("customerID", ArgumentSemantic.Strong)]
		NSNumber CustomerID { get; }
	}

	// @interface FlyBuyOrderEvent : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyOrderEvent
	{
		// -(instancetype _Nonnull)initWithOrderID:(NSInteger)orderID customerState:(NSString * _Nonnull)customerState etaSeconds:(NSNumber * _Nullable)etaSeconds __attribute__((objc_designated_initializer));
		[Export ("initWithOrderID:customerState:etaSeconds:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint orderID, string customerState, [NullAllowed] NSNumber etaSeconds);

		// -(instancetype _Nonnull)initWithOrderID:(NSInteger)orderID state:(NSString * _Nonnull)state __attribute__((objc_designated_initializer));
		[Export ("initWithOrderID:state:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint orderID, string state);

		// -(instancetype _Nonnull)initWithOrderID:(NSInteger)orderID locationAuthStatus:(enum LocationAuthStatus)locationAuthStatus __attribute__((objc_designated_initializer));
		[Export ("initWithOrderID:locationAuthStatus:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint orderID, LocationAuthStatus locationAuthStatus);

		// -(instancetype _Nonnull)initWithOrderID:(NSInteger)orderID customerRating:(NSInteger)customerRating customerComments:(NSString * _Nullable)customerComments __attribute__((objc_designated_initializer));
		[Export ("initWithOrderID:customerRating:customerComments:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint orderID, nint customerRating, [NullAllowed] string customerComments);
	}

	// @interface FlyBuyOrdersManager : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuyOrdersManager
	{
		// @property (readonly, copy, nonatomic) NSArray<FlyBuyOrder *> * _Nonnull all;
		[Export ("all", ArgumentSemantic.Copy)]
		FlyBuyOrder[] All { get; }

		// @property (readonly, copy, nonatomic) NSArray<FlyBuyOrder *> * _Nonnull open;
		[Export ("open", ArgumentSemantic.Copy)]
		FlyBuyOrder[] Open { get; }

		// @property (readonly, copy, nonatomic) NSArray<FlyBuyOrder *> * _Nonnull closed;
		[Export ("closed", ArgumentSemantic.Copy)]
		FlyBuyOrder[] Closed { get; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull orderStates;
		[Export ("orderStates", ArgumentSemantic.Copy)]
		string[] OrderStates { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull customerStates;
		[Export ("customerStates", ArgumentSemantic.Copy)]
		string[] CustomerStates { get; set; }

		// -(void)fetchWithCallback:(void (^ _Nullable)(NSArray<FlyBuyOrder *> * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchWithCallback:")]
		void FetchWithCallback ([NullAllowed] Action<NSArray<FlyBuyOrder>, NSError> callback);

		// -(void)fetchWithRedemptionCode:(NSString * _Nonnull)redemptionCode callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchWithRedemptionCode:callback:")]
		void FetchWithRedemptionCode (string redemptionCode, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)claimWithRedemptionCode:(NSString * _Nonnull)redemptionCode customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pickupType:(NSString * _Nullable)pickupType callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("claimWithRedemptionCode:customerInfo:pickupType:callback:")]
		void ClaimWithRedemptionCode (string redemptionCode, FlyBuyCustomerInfo customerInfo, [NullAllowed] string pickupType, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pickupWindow:(FlyBuyPickupWindow * _Nullable)pickupWindow state:(NSString * _Nonnull)state callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("createWithSiteID:partnerIdentifier:customerInfo:pickupWindow:state:callback:")]
		void CreateWithSiteID (nint siteID, string partnerIdentifier, FlyBuyCustomerInfo customerInfo, [NullAllowed] FlyBuyPickupWindow pickupWindow, string state, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pickupWindow:(FlyBuyPickupWindow * _Nullable)pickupWindow callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("createWithSiteID:partnerIdentifier:customerInfo:pickupWindow:callback:")]
		void CreateWithSiteID (nint siteID, string partnerIdentifier, FlyBuyCustomerInfo customerInfo, [NullAllowed] FlyBuyPickupWindow pickupWindow, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)updateCustomerStateWithOrderID:(NSInteger)orderID customerState:(NSString * _Nonnull)customerState callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("updateCustomerStateWithOrderID:customerState:callback:")]
		void UpdateCustomerStateWithOrderID (nint orderID, string customerState, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)updateOrderStateWithOrderID:(NSInteger)orderID state:(NSString * _Nonnull)state callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("updateOrderStateWithOrderID:state:callback:")]
		void UpdateOrderStateWithOrderID (nint orderID, string state, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)rateOrderWithOrderID:(NSInteger)orderID rating:(NSInteger)rating comments:(NSString * _Nullable)comments callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("rateOrderWithOrderID:rating:comments:callback:")]
		void RateOrderWithOrderID (nint orderID, nint rating, [NullAllowed] string comments, [NullAllowed] Action<FlyBuyOrder, NSError> callback);
	}

	// @interface FlyBuyOrdersManagerError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyOrdersManagerError
	{
	}

	// @interface FlyBuyPagination : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyPagination
	{
		// @property (readonly, nonatomic) NSInteger currentPage;
		[Export ("currentPage")]
		nint CurrentPage { get; }

		// @property (readonly, nonatomic) NSInteger totalPages;
		[Export ("totalPages")]
		nint TotalPages { get; }
	}

	// @interface FlyBuyPickupWindow : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyPickupWindow
	{
		// @property (readonly, copy, nonatomic) NSDate * _Nonnull start;
		[Export ("start", ArgumentSemantic.Copy)]
		NSDate Start { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull end;
		[Export ("end", ArgumentSemantic.Copy)]
		NSDate End { get; }

		// -(instancetype _Nonnull)initWithStart:(NSDate * _Nonnull)start end:(NSDate * _Nonnull)end __attribute__((objc_designated_initializer));
		[Export ("initWithStart:end:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSDate start, NSDate end);

		// -(instancetype _Nonnull)init:(NSDate * _Nonnull)date;
		[Export ("init:")]
		IntPtr Constructor (NSDate date);
	}

	// @interface FlyBuyRequestPasswordReset : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyRequestPasswordReset
	{
	}

	// @interface FlyBuySetNewPassword : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuySetNewPassword
	{
		// -(instancetype _Nonnull)initWithResetPasswordToken:(NSString * _Nonnull)resetPasswordToken password:(NSString * _Nonnull)password confirmation:(NSString * _Nonnull)confirmation __attribute__((objc_designated_initializer));
		[Export ("initWithResetPasswordToken:password:confirmation:")]
		[DesignatedInitializer]
		IntPtr Constructor (string resetPasswordToken, string password, string confirmation);
	}

	// @interface FlyBuySignUpInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuySignUpInfo
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull emailAddress;
		[Export ("emailAddress")]
		string EmailAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull password;
		[Export ("password")]
		string Password { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull passwordConfirmation;
		[Export ("passwordConfirmation")]
		string PasswordConfirmation { get; }

		// -(instancetype _Nonnull)initWithEmailAddress:(NSString * _Nonnull)emailAddress password:(NSString * _Nonnull)password passwordConfirmation:(NSString * _Nonnull)passwordConfirmation __attribute__((objc_designated_initializer));
		[Export ("initWithEmailAddress:password:passwordConfirmation:")]
		[DesignatedInitializer]
		IntPtr Constructor (string emailAddress, string password, string passwordConfirmation);
	}

	// @interface FlyBuySite : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuySite : INativeObject
	{
		// @property (readonly, nonatomic) NSInteger id;
		[Export ("id")]
		nint Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable partnerIdentifier;
		[NullAllowed, Export ("partnerIdentifier")]
		string PartnerIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable streetAddress;
		[NullAllowed, Export ("streetAddress")]
		string StreetAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable fullAddress;
		[NullAllowed, Export ("fullAddress")]
		string FullAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable locality;
		[NullAllowed, Export ("locality")]
		string Locality { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable region;
		[NullAllowed, Export ("region")]
		string Region { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable longitude;
		[NullAllowed, Export ("longitude")]
		string Longitude { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable latitude;
		[NullAllowed, Export ("latitude")]
		string Latitude { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable instructions;
		[NullAllowed, Export ("instructions")]
		string Instructions { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable descriptionText;
		[NullAllowed, Export ("descriptionText")]
		string DescriptionText { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable coverPhotoURL;
		[NullAllowed, Export ("coverPhotoURL")]
		string CoverPhotoURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable projectAccentColor;
		[NullAllowed, Export ("projectAccentColor")]
		string ProjectAccentColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable projectAccentTextColor;
		[NullAllowed, Export ("projectAccentTextColor")]
		string ProjectAccentTextColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable projectLogoURL;
		[NullAllowed, Export ("projectLogoURL")]
		string ProjectLogoURL { get; }

		// @property (readonly, nonatomic, strong) FlyBuyGeofence * _Nullable geofence;
		[NullAllowed, Export ("geofence", ArgumentSemantic.Strong)]
		FlyBuyGeofence Geofence { get; }

		// -(CLLocation * _Nullable)location __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("location")]
		CLLocation Location { get; }

		// -(NSNumber * _Nullable)distanceFrom:(CLLocation * _Nonnull)loc __attribute__((warn_unused_result("")));
		[Export ("distanceFrom:")]
		[return: NullAllowed]
		NSNumber DistanceFrom (CLLocation loc);
	}

	// @interface FlyBuySitesManager : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuySitesManager
	{
		// @property (readonly, copy, nonatomic) NSArray<FlyBuySite *> * _Nullable all;
		[NullAllowed, Export ("all", ArgumentSemantic.Copy)]
		FlyBuySite[] All { get; }

		// -(void)fetchWithQuery:(NSString * _Nullable)query page:(NSInteger)page callback:(void (^ _Nullable)(NSArray<FlyBuySite *> * _Nullable, FlyBuyPagination * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchWithQuery:page:callback:")]
		void FetchWithQuery ([NullAllowed] string query, nint page, [NullAllowed] Action<NSArray<FlyBuySite>, FlyBuyPagination, NSError> callback);

		// -(void)fetchWithRegion:(CLCircularRegion * _Nonnull)region page:(NSInteger)page callback:(void (^ _Nullable)(NSArray<FlyBuySite *> * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchWithRegion:page:callback:")]
		void FetchWithRegion (CLCircularRegion region, nint page, [NullAllowed] Action<NSArray<FlyBuySite>, NSError> callback);

		// -(void)fetchWithRegion:(CLCircularRegion * _Nonnull)region page:(NSInteger)page per:(NSInteger)per callback:(void (^ _Nullable)(NSArray<FlyBuySite *> * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchWithRegion:page:per:callback:")]
		void FetchWithRegion (CLCircularRegion region, nint page, nint per, [NullAllowed] Action<NSArray<FlyBuySite>, NSError> callback);

		// -(void)fetchAllWithQuery:(NSString * _Nullable)query callback:(void (^ _Nullable)(NSArray<FlyBuySite *> * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchAllWithQuery:callback:")]
		void FetchAllWithQuery ([NullAllowed] string query, [NullAllowed] Action<NSArray<FlyBuySite>, NSError> callback);
	}

	// @interface FlyBuySitesManagerError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuySitesManagerError
	{
	}

	// @interface FlyBuyUpdateOrderInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyUpdateOrderInfo
	{
		// -(instancetype _Nonnull)initWithPushToken:(NSString * _Nonnull)pushToken __attribute__((objc_designated_initializer));
		[Export ("initWithPushToken:")]
		[DesignatedInitializer]
		IntPtr Constructor (string pushToken);
	}
}
