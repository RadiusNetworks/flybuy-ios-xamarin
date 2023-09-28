using System;
using Foundation;
using ObjCRuntime;

namespace FlyBuy
{
	[Static]
	partial interface Constants
	{
		// extern double FlyBuyPresenceVersionNumber;
		[Field ("FlyBuyPresenceVersionNumber", "__Internal")]
		double FlyBuyPresenceVersionNumber { get; }

		// extern const unsigned char[] FlyBuyPresenceVersionString;
		[Field ("FlyBuyPresenceVersionString", "__Internal")]
		byte[] FlyBuyPresenceVersionString { get; }
	}

	// @interface FlyBuyPresenceManager : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuyPresenceManager
	{
		// @property (readonly, nonatomic, strong, class) FlyBuyPresenceManager * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		FlyBuyPresenceManager Shared { get; }

		// @property (readonly, nonatomic) NSInteger maxPayloadSize;
		[Export ("maxPayloadSize")]
		nint MaxPayloadSize { get; }

		// @property (readonly, copy, nonatomic) NSUUID * _Nullable presenceUUID;
		[NullAllowed, Export ("presenceUUID", ArgumentSemantic.Copy)]
		NSUuid PresenceUUID { get; }

		// -(void)configureWithPresenceUUID:(NSUUID * _Nonnull)presenceUUID;
		[Export ("configureWithPresenceUUID:")]
		void ConfigureWithPresenceUUID (NSUuid presenceUUID);

		// -(void)createLocatorWithPayload:(NSString * _Nullable)payload callback:(void (^ _Nonnull)(PresenceLocator * _Nullable, NSError * _Nullable))callback;
		[Export ("createLocatorWithPayload:callback:")]
		void CreateLocatorWithPayload ([NullAllowed] string payload, Action<PresenceLocator, NSError> callback);

		// -(void)createLocatorWithIdentifier:(NSData * _Nonnull)presenceIdentifier payload:(NSString * _Nullable)payload callback:(void (^ _Nonnull)(PresenceLocator * _Nullable, NSError * _Nullable))callback;
		[Export ("createLocatorWithIdentifier:payload:callback:")]
		void CreateLocatorWithIdentifier (NSData presenceIdentifier, [NullAllowed] string payload, Action<PresenceLocator, NSError> callback);

		// -(void)start:(PresenceLocator * _Nonnull)locator;
		[Export ("start:")]
		void Start (PresenceLocator locator);

		// -(NSError * _Nullable)stop __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("stop")]
		NSError Stop { get; }
	}

	// @interface FlyBuyPresenceError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyPresenceError
	{
		// @property (readonly, nonatomic) enum PresenceErrorType type;
		[Export ("type")]
		PresenceErrorType Type { get; }

		// -(instancetype _Nonnull)init:(enum PresenceErrorType)typeIn __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (PresenceErrorType typeIn);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface PresenceLocator : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14FlyBuyPresence15PresenceLocator")]
	[DisableDefaultCtor]
	interface PresenceLocator
	{
	}

	// @protocol PresenceLocatorDelegate
	[Protocol (Name = "_TtP14FlyBuyPresence23PresenceLocatorDelegate_"), Model (AutoGeneratedName = true)]
	interface PresenceLocatorDelegate
	{
		// @optional -(void)locatorDidStart:(PresenceLocator * _Nonnull)locator;
		[Export ("locatorDidStart:")]
		void LocatorDidStart (PresenceLocator locator);

		// @optional -(void)locatorDidStop:(PresenceLocator * _Nonnull)locator;
		[Export ("locatorDidStop:")]
		void LocatorDidStop (PresenceLocator locator);

		// @optional -(void)locatorDidFail:(PresenceLocator * _Nonnull)locator error:(NSError * _Nonnull)error;
		[Export ("locatorDidFail:error:")]
		void LocatorDidFail (PresenceLocator locator, NSError error);

		// @optional -(void)locator:(PresenceLocator * _Nonnull)locator didReceiveEvent:(uint8_t)type;
		[Export ("locator:didReceiveEvent:")]
		void Locator (PresenceLocator locator, byte type);
	}
}
