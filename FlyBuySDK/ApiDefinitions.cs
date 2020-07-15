using System;
using CoreData;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace FlyBuy
{
    // @interface ClaimOrderInfo : NSObject
    [BaseType (typeof(NSObject), Name = "_TtC6FlyBuy14ClaimOrderInfo")]
	[DisableDefaultCtor]
	interface ClaimOrderInfo
	{
		// -(instancetype _Nonnull)initWithCustomerCarColor:(NSString * _Nullable)customerCarColor customerCarType:(NSString * _Nullable)customerCarType customerLicensePlate:(NSString * _Nullable)customerLicensePlate customerName:(NSString * _Nullable)customerName customerPhone:(NSString * _Nullable)customerPhone pushToken:(NSString * _Nonnull)pushToken __attribute__((objc_designated_initializer));
		[Export ("initWithCustomerCarColor:customerCarType:customerLicensePlate:customerName:customerPhone:pushToken:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string customerCarColor, [NullAllowed] string customerCarType, [NullAllowed] string customerLicensePlate, [NullAllowed] string customerName, [NullAllowed] string customerPhone, string pushToken);

		// -(instancetype _Nonnull)initWithCustomerInfo:(CustomerInfo * _Nonnull)customerInfo pushToken:(NSString * _Nonnull)pushToken pickupType:(NSString * _Nullable)pickupType __attribute__((objc_designated_initializer));
		[Export ("initWithCustomerInfo:pushToken:pickupType:")]
		[DesignatedInitializer]
		IntPtr Constructor (CustomerInfo customerInfo, string pushToken, [NullAllowed] string pickupType);
	}

	// @interface ConfigurationManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy20ConfigurationManager")]
	interface ConfigurationManager
	{
		// -(void)fetchWithCallback:(void (^ _Nullable)(NSDictionary<NSString *,id> * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchWithCallback:")]
		void FetchWithCallback ([NullAllowed] Action<NSDictionary<NSString, NSObject>, NSError> callback);
	}

	// @interface CoreOrder : NSManagedObject
	[BaseType (typeof(NSManagedObject), Name = "_TtC6FlyBuy9CoreOrder")]
	interface CoreOrder
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface FlyBuy_Swift_242 (CoreOrder)
	[Category]
	[BaseType (typeof(CoreOrder))]
	interface CoreOrder_FlyBuy_Swift_242
	{
		// @property (nonatomic) int64_t customerState;
		[Export("customerState")]
		long Get_CustomerState();

		[Export("setCustomerState:")]
		void Set_CustomerState(long value);

		// @property (nonatomic) int64_t id;
		[Export("id")]
		long Get_Id();

		[Export("setId:")]
		void Set_Id(long value);

		// @property (copy, nonatomic) NSString * _Nullable partnerIdentifier;
		[NullAllowed, Export("partnerIdentifier")]
		string Get_PartnerIdentifier();

		[NullAllowed, Export("setPartnerIdentifier:")]
		void Set_PartnerIdentifier(string value);

		// @property (nonatomic) int64_t siteId;
		[Export("siteId")]
		long Get_SiteId();

		[Export("setSiteId:")]
		void Set_SiteId(long value);

		// @property (nonatomic) int64_t state;
		[Export("state")]
		long Get_State();

		[Export("setState:")]
		void Set_State(long value);
	}

	// @interface CreateOrderInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy15CreateOrderInfo")]
	[DisableDefaultCtor]
	interface CreateOrderInfo
	{
		// -(instancetype _Nonnull)initWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerCarColor:(NSString * _Nullable)customerCarColor customerCarType:(NSString * _Nullable)customerCarType customerLicensePlate:(NSString * _Nullable)customerLicensePlate customerName:(NSString * _Nullable)customerName customerPhone:(NSString * _Nullable)customerPhone pushToken:(NSString * _Nullable)pushToken state:(enum OrderState)state pickupWindow:(PickupWindow * _Nullable)pickupWindow __attribute__((objc_designated_initializer));
		[Export ("initWithSiteID:partnerIdentifier:customerCarColor:customerCarType:customerLicensePlate:customerName:customerPhone:pushToken:state:pickupWindow:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint siteID, string partnerIdentifier, [NullAllowed] string customerCarColor, [NullAllowed] string customerCarType, [NullAllowed] string customerLicensePlate, [NullAllowed] string customerName, [NullAllowed] string customerPhone, [NullAllowed] string pushToken, OrderState state, [NullAllowed] PickupWindow pickupWindow);

		// -(instancetype _Nonnull)initWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerCarColor:(NSString * _Nullable)customerCarColor customerCarType:(NSString * _Nullable)customerCarType customerLicensePlate:(NSString * _Nullable)customerLicensePlate customerName:(NSString * _Nullable)customerName customerPhone:(NSString * _Nullable)customerPhone pushToken:(NSString * _Nullable)pushToken pickupWindow:(PickupWindow * _Nullable)pickupWindow __attribute__((objc_designated_initializer));
		[Export ("initWithSiteID:partnerIdentifier:customerCarColor:customerCarType:customerLicensePlate:customerName:customerPhone:pushToken:pickupWindow:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint siteID, string partnerIdentifier, [NullAllowed] string customerCarColor, [NullAllowed] string customerCarType, [NullAllowed] string customerLicensePlate, [NullAllowed] string customerName, [NullAllowed] string customerPhone, [NullAllowed] string pushToken, [NullAllowed] PickupWindow pickupWindow);
	}

	// @interface Customer : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy8Customer")]
	[DisableDefaultCtor]
	interface Customer
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull token;
		[Export ("token")]
		string Token { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable emailAddress;
		[NullAllowed, Export ("emailAddress")]
		string EmailAddress { get; }

		// @property (readonly, nonatomic, strong) CustomerInfo * _Nonnull info;
		[Export ("info", ArgumentSemantic.Strong)]
		CustomerInfo Info { get; }

		// @property (readonly, nonatomic) BOOL registered;
		[Export ("registered")]
		bool Registered { get; }
	}

	// @interface CustomerConsent : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy15CustomerConsent")]
	[DisableDefaultCtor]
	interface CustomerConsent
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

	// @interface CustomerInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy12CustomerInfo")]
	[DisableDefaultCtor]
	interface CustomerInfo
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

	// @interface CustomerManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy15CustomerManager")]
	[DisableDefaultCtor]
	interface CustomerManager
	{
		// @property (readonly, nonatomic, strong) Customer * _Nullable current;
		[NullAllowed, Export ("current", ArgumentSemantic.Strong)]
		Customer Current { get; }

		// -(void)create:(CustomerInfo * _Nonnull)customerInfo termsOfService:(BOOL)termsOfService ageVerification:(BOOL)ageVerification callback:(void (^ _Nullable)(Customer * _Nullable, NSError * _Nullable))callback;
		[Export ("create:termsOfService:ageVerification:callback:")]
		void Create (CustomerInfo customerInfo, bool termsOfService, bool ageVerification, [NullAllowed] Action<Customer, NSError> callback);

		// -(void)create:(CustomerInfo * _Nonnull)customerInfo customerConsent:(CustomerConsent * _Nonnull)customerConsent callback:(void (^ _Nullable)(Customer * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("Method Deprecated")));
		[Export ("create:customerConsent:callback:")]
		void Create (CustomerInfo customerInfo, CustomerConsent customerConsent, [NullAllowed] Action<Customer, NSError> callback);

		// -(void)update:(CustomerInfo * _Nonnull)customerInfo callback:(void (^ _Nullable)(Customer * _Nullable, NSError * _Nullable))callback;
		[Export ("update:callback:")]
		void Update (CustomerInfo customerInfo, [NullAllowed] Action<Customer, NSError> callback);

		// -(void)loginWithEmailAddress:(NSString * _Nonnull)emailAddress password:(NSString * _Nonnull)password callback:(void (^ _Nullable)(Customer * _Nullable, NSError * _Nullable))callback;
		[Export ("loginWithEmailAddress:password:callback:")]
		void LoginWithEmailAddress (string emailAddress, string password, [NullAllowed] Action<Customer, NSError> callback);

		// -(void)loginWithTokenWithToken:(NSString * _Nonnull)token callback:(void (^ _Nullable)(Customer * _Nullable, NSError * _Nullable))callback;
		[Export ("loginWithTokenWithToken:callback:")]
		void LoginWithTokenWithToken (string token, [NullAllowed] Action<Customer, NSError> callback);

		// -(void)signUpWithEmailAddress:(NSString * _Nonnull)emailAddress password:(NSString * _Nonnull)password callback:(void (^ _Nullable)(Customer * _Nullable, NSError * _Nullable))callback;
		[Export ("signUpWithEmailAddress:password:callback:")]
		void SignUpWithEmailAddress (string emailAddress, string password, [NullAllowed] Action<Customer, NSError> callback);

		// -(void)logout;
		[Export ("logout")]
		void Logout ();

		// -(void)signOut __attribute__((deprecated("Method Deprecated")));
		[Export ("signOut")]
		void SignOut ();
	}

	// @interface FlyBuy : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy6FlyBuy")]
	[DisableDefaultCtor]
	interface FlyBuy
	{
		// @property (readonly, nonatomic, strong, class) OrdersManager * _Nonnull orders;
		[Static]
		[Export ("orders", ArgumentSemantic.Strong)]
		OrdersManager Orders { get; }

		// @property (readonly, nonatomic, strong, class) CustomerManager * _Nonnull customer;
		[Static]
		[Export ("customer", ArgumentSemantic.Strong)]
		CustomerManager Customer { get; }

		// @property (readonly, nonatomic, strong, class) SitesManager * _Nonnull sites;
		[Static]
		[Export ("sites", ArgumentSemantic.Strong)]
		SitesManager Sites { get; }

		// @property (readonly, nonatomic, strong, class) ConfigurationManager * _Nonnull config;
		[Static]
		[Export ("config", ArgumentSemantic.Strong)]
		ConfigurationManager Config { get; }

		// +(void)configure:(NSDictionary<NSString *,id> * _Nonnull)opts;
		[Static]
		[Export ("configure:")]
		void Configure (NSDictionary<NSString, NSObject> opts);

		// +(void)handleRemoteNotification:(NSDictionary * _Nonnull)data;
		[Static]
		[Export ("handleRemoteNotification:")]
		void HandleRemoteNotification (NSDictionary data);

		// +(void)stopLocationUpdates;
		[Static]
		[Export ("stopLocationUpdates")]
		void StopLocationUpdates ();

		// +(void)updatePushToken:(NSString * _Nonnull)newPushToken;
		[Static]
		[Export ("updatePushToken:")]
		void UpdatePushToken (string newPushToken);

		// +(void)updateAPNPushToken:(NSData * _Nonnull)deviceToken;
		[Static]
		[Export ("updateAPNPushToken:")]
		void UpdateAPNPushToken (NSData deviceToken);
	}

	// @interface LoginInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy9LoginInfo")]
	[DisableDefaultCtor]
	interface LoginInfo
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

	// @interface Order : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy5Order")]
	interface Order : INativeObject
	{
		// @property (readonly, nonatomic) NSInteger id;
		[Export ("id")]
		nint Id { get; }

		// @property (readonly, nonatomic) NSInteger siteID;
		[Export ("siteID")]
		nint SiteID { get; }

		// @property (nonatomic) enum OrderState state;
		[Export ("state", ArgumentSemantic.Assign)]
		OrderState State { get; set; }

		// @property (nonatomic) enum CustomerState customerState;
		[Export ("customerState", ArgumentSemantic.Assign)]
		CustomerState CustomerState { get; set; }

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

		// @property (readonly, nonatomic, strong) PickupWindow * _Nullable pickupWindow;
		[NullAllowed, Export ("pickupWindow", ArgumentSemantic.Strong)]
		PickupWindow PickupWindow { get; }

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

		// @property (copy, nonatomic) NSString * _Nullable pushToken;
		[NullAllowed, Export ("pushToken")]
		string PushToken { get; set; }

		// -(CLLocation * _Nullable)siteLocation __attribute__((warn_unused_result));
		[NullAllowed, Export ("siteLocation")]
		CLLocation SiteLocation { get; }

		// -(NSNumber * _Nullable)siteDistanceFrom:(CLLocation * _Nonnull)location __attribute__((warn_unused_result));
		[Export ("siteDistanceFrom:")]
		[return: NullAllowed]
		NSNumber SiteDistanceFrom (CLLocation location);

		// -(BOOL)isOpen __attribute__((warn_unused_result));
		[Export ("isOpen")]
		bool IsOpen { get; }
	}

	// @interface OrderEvent : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy10OrderEvent")]
	[DisableDefaultCtor]
	interface OrderEvent
	{
		// -(instancetype _Nonnull)initWithOrderID:(NSInteger)orderID customerState:(enum CustomerState)customerState etaSeconds:(NSNumber * _Nullable)etaSeconds __attribute__((objc_designated_initializer));
		[Export ("initWithOrderID:customerState:etaSeconds:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint orderID, CustomerState customerState, [NullAllowed] NSNumber etaSeconds);

		// -(instancetype _Nonnull)initWithOrderID:(NSInteger)orderID state:(enum OrderState)state __attribute__((objc_designated_initializer));
		[Export ("initWithOrderID:state:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint orderID, OrderState state);

		// -(instancetype _Nonnull)initWithOrderID:(NSInteger)orderID locationAuthStatus:(enum LocationAuthStatus)locationAuthStatus __attribute__((objc_designated_initializer));
		[Export ("initWithOrderID:locationAuthStatus:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint orderID, LocationAuthStatus locationAuthStatus);

		// -(instancetype _Nonnull)initWithOrderID:(NSInteger)orderID customerRating:(NSInteger)customerRating customerComments:(NSString * _Nullable)customerComments __attribute__((objc_designated_initializer));
		[Export ("initWithOrderID:customerRating:customerComments:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint orderID, nint customerRating, [NullAllowed] string customerComments);
	}

	// @interface OrdersManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy13OrdersManager")]
	interface OrdersManager
	{
		// @property (readonly, copy, nonatomic) NSArray<Order *> * _Nullable all;
		[NullAllowed, Export ("all", ArgumentSemantic.Copy)]
		Order[] All { get; }

		// @property (readonly, copy, nonatomic) NSArray<Order *> * _Nullable open;
		[NullAllowed, Export ("open", ArgumentSemantic.Copy)]
		Order[] Open { get; }

		// @property (readonly, copy, nonatomic) NSArray<Order *> * _Nullable closed;
		[NullAllowed, Export ("closed", ArgumentSemantic.Copy)]
		Order[] Closed { get; }

		// -(void)fetchWithCallback:(void (^ _Nullable)(NSArray<Order *> * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchWithCallback:")]
		void FetchWithCallback ([NullAllowed] Action<NSArray<Order>, NSError> callback);

		// -(void)fetchWithRedemptionCode:(NSString * _Nonnull)redemptionCode callback:(void (^ _Nullable)(Order * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchWithRedemptionCode:callback:")]
		void FetchWithRedemptionCode (string redemptionCode, [NullAllowed] Action<Order, NSError> callback);

		// -(void)claimWithRedemptionCode:(NSString * _Nonnull)redemptionCode customerInfo:(CustomerInfo * _Nonnull)customerInfo pickupType:(NSString * _Nullable)pickupType callback:(void (^ _Nullable)(Order * _Nullable, NSError * _Nullable))callback;
		[Export ("claimWithRedemptionCode:customerInfo:pickupType:callback:")]
		void ClaimWithRedemptionCode (string redemptionCode, CustomerInfo customerInfo, [NullAllowed] string pickupType, [NullAllowed] Action<Order, NSError> callback);

		// -(void)claimWithRedemptionCode:(NSString * _Nonnull)redemptionCode customerInfo:(CustomerInfo * _Nonnull)customerInfo callback:(void (^ _Nullable)(Order * _Nullable, NSError * _Nullable))callback;
		[Export ("claimWithRedemptionCode:customerInfo:callback:")]
		void ClaimWithRedemptionCode (string redemptionCode, CustomerInfo customerInfo, [NullAllowed] Action<Order, NSError> callback);

		// -(void)claimWithRedemptionCode:(NSString * _Nonnull)redemptionCode claimOrderInfo:(ClaimOrderInfo * _Nonnull)claimOrderInfo customerConsent:(CustomerConsent * _Nullable)customerConsent callback:(void (^ _Nullable)(Order * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("Method Deprecated")));
		[Export ("claimWithRedemptionCode:claimOrderInfo:customerConsent:callback:")]
		void ClaimWithRedemptionCode (string redemptionCode, ClaimOrderInfo claimOrderInfo, [NullAllowed] CustomerConsent customerConsent, [NullAllowed] Action<Order, NSError> callback);

		// -(void)createWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerInfo:(CustomerInfo * _Nonnull)customerInfo pickupWindow:(PickupWindow * _Nullable)pickupWindow state:(enum OrderState)state callback:(void (^ _Nullable)(Order * _Nullable, NSError * _Nullable))callback;
		[Export ("createWithSiteID:partnerIdentifier:customerInfo:pickupWindow:state:callback:")]
		void CreateWithSiteID (nint siteID, string partnerIdentifier, CustomerInfo customerInfo, [NullAllowed] PickupWindow pickupWindow, OrderState state, [NullAllowed] Action<Order, NSError> callback);

		// -(void)createWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerInfo:(CustomerInfo * _Nonnull)customerInfo pickupWindow:(PickupWindow * _Nullable)pickupWindow callback:(void (^ _Nullable)(Order * _Nullable, NSError * _Nullable))callback;
		[Export ("createWithSiteID:partnerIdentifier:customerInfo:pickupWindow:callback:")]
		void CreateWithSiteID (nint siteID, string partnerIdentifier, CustomerInfo customerInfo, [NullAllowed] PickupWindow pickupWindow, [NullAllowed] Action<Order, NSError> callback);

		// -(void)createWithInfo:(CreateOrderInfo * _Nonnull)info callback:(void (^ _Nullable)(Order * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("Method Deprecated")));
		[Export ("createWithInfo:callback:")]
		void CreateWithInfo (CreateOrderInfo info, [NullAllowed] Action<Order, NSError> callback);

		// -(void)eventWithOrder:(Order * _Nonnull)order customerState:(enum CustomerState)customerState callback:(void (^ _Nullable)(Order * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("Method Deprecated")));
		[Export ("eventWithOrder:customerState:callback:")]
		void EventWithOrder (Order order, CustomerState customerState, [NullAllowed] Action<Order, NSError> callback);

		// -(void)eventWithOrderID:(NSInteger)orderID customerState:(enum CustomerState)customerState callback:(void (^ _Nullable)(Order * _Nullable, NSError * _Nullable))callback;
		[Export ("eventWithOrderID:customerState:callback:")]
		void EventWithOrderID (nint orderID, CustomerState customerState, [NullAllowed] Action<Order, NSError> callback);

		// -(void)eventWithOrderID:(NSInteger)orderID state:(enum OrderState)state callback:(void (^ _Nullable)(Order * _Nullable, NSError * _Nullable))callback;
		[Export ("eventWithOrderID:state:callback:")]
		void EventWithOrderID (nint orderID, OrderState state, [NullAllowed] Action<Order, NSError> callback);

		// -(void)rateOrderWithOrderID:(NSInteger)orderID rating:(NSInteger)rating comments:(NSString * _Nullable)comments callback:(void (^ _Nullable)(Order * _Nullable, NSError * _Nullable))callback;
		[Export ("rateOrderWithOrderID:rating:comments:callback:")]
		void RateOrderWithOrderID (nint orderID, nint rating, [NullAllowed] string comments, [NullAllowed] Action<Order, NSError> callback);
	}

	// @interface Pagination : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy10Pagination")]
	[DisableDefaultCtor]
	interface Pagination
	{
		// @property (readonly, nonatomic) NSInteger currentPage;
		[Export ("currentPage")]
		nint CurrentPage { get; }

		// @property (readonly, nonatomic) NSInteger totalPages;
		[Export ("totalPages")]
		nint TotalPages { get; }
	}

	// @interface PickupWindow : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy12PickupWindow")]
	[DisableDefaultCtor]
	interface PickupWindow
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

	// @interface SignUpInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy10SignUpInfo")]
	[DisableDefaultCtor]
	interface SignUpInfo
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

	// @interface Site : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy4Site")]
	interface Site : INativeObject
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

		// -(CLLocation * _Nullable)location __attribute__((warn_unused_result));
		[NullAllowed, Export ("location")]
		CLLocation Location { get; }

		// -(NSNumber * _Nullable)distanceFrom:(CLLocation * _Nonnull)loc __attribute__((warn_unused_result));
		[Export ("distanceFrom:")]
		[return: NullAllowed]
		NSNumber DistanceFrom (CLLocation loc);
	}

	// @interface SitesManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy12SitesManager")]
	interface SitesManager
	{
		// @property (readonly, copy, nonatomic) NSArray<Site *> * _Nullable all;
		[NullAllowed, Export ("all", ArgumentSemantic.Copy)]
		Site[] All { get; }

		// -(void)fetchWithQuery:(NSString * _Nullable)query page:(NSInteger)page callback:(void (^ _Nullable)(NSArray<Site *> * _Nullable, Pagination * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchWithQuery:page:callback:")]
		void FetchWithQuery ([NullAllowed] string query, nint page, [NullAllowed] Action<NSArray<Site>, Pagination, NSError> callback);

		// -(void)fetchAllWithQuery:(NSString * _Nullable)query callback:(void (^ _Nullable)(NSArray<Site *> * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchAllWithQuery:callback:")]
		void FetchAllWithQuery ([NullAllowed] string query, [NullAllowed] Action<NSArray<Site>, NSError> callback);
	}

	// @interface UpdateOrderInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy15UpdateOrderInfo")]
	[DisableDefaultCtor]
	interface UpdateOrderInfo
	{
		// -(instancetype _Nonnull)initWithPushToken:(NSString * _Nonnull)pushToken __attribute__((objc_designated_initializer));
		[Export ("initWithPushToken:")]
		[DesignatedInitializer]
		IntPtr Constructor (string pushToken);
	}
}
