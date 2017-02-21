using System;
using Foundation;
using ObjCRuntime;

namespace Quantcast {

	[BaseType (typeof (NSObject))]
	public partial interface QuantcastMeasurement {

		[Static, Export ("sharedInstance")]
		QuantcastMeasurement SharedInstance { get; }

		[Export ("setupMeasurementSessionWithAPIKey:userIdentifier:labels:")]
		string SetupMeasurementSessionWithAPIKey (string inQuantcastAPIKey, [NullAllowed] string userIdentifierOrNil, [NullAllowed] NSObject inLabelsOrNil);

		[Export ("recordUserIdentifier:withLabels:")]
		string RecordUserIdentifier ([NullAllowed] string inUserIdentifierOrNil, [NullAllowed] NSObject inLabelsOrNil);
	}
}
