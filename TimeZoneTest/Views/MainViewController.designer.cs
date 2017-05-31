// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TimeZoneTest.Views
{
    [Register ("MainViewController")]
    partial class MainViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch ApplyFixSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel nativeLocalTimeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel nativeTimeZoneLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel nativeUtcTimeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel xamarinLocalTimeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel xamarinTimeZoneLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel xamarinUtcTimeLabel { get; set; }

        [Action ("ApplyFixSwitch_ValueChanged")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ApplyFixSwitch_ValueChanged ();

        void ReleaseDesignerOutlets ()
        {
            if (ApplyFixSwitch != null) {
                ApplyFixSwitch.Dispose ();
                ApplyFixSwitch = null;
            }

            if (nativeLocalTimeLabel != null) {
                nativeLocalTimeLabel.Dispose ();
                nativeLocalTimeLabel = null;
            }

            if (nativeTimeZoneLabel != null) {
                nativeTimeZoneLabel.Dispose ();
                nativeTimeZoneLabel = null;
            }

            if (nativeUtcTimeLabel != null) {
                nativeUtcTimeLabel.Dispose ();
                nativeUtcTimeLabel = null;
            }

            if (xamarinLocalTimeLabel != null) {
                xamarinLocalTimeLabel.Dispose ();
                xamarinLocalTimeLabel = null;
            }

            if (xamarinTimeZoneLabel != null) {
                xamarinTimeZoneLabel.Dispose ();
                xamarinTimeZoneLabel = null;
            }

            if (xamarinUtcTimeLabel != null) {
                xamarinUtcTimeLabel.Dispose ();
                xamarinUtcTimeLabel = null;
            }
        }
    }
}