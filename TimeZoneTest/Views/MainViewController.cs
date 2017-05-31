using System;
using Foundation;
using UIKit;
namespace TimeZoneTest.Views
{
    public partial class MainViewController : UIViewController
    {
        private readonly DateTime _xamarinTimestamp;
        private readonly NSDate _nativeTimestamp;
        private NSObject _timeChangeObserver;

        public MainViewController() : base("MainViewController", null)
        {
            _xamarinTimestamp = DateTime.UtcNow;
            _nativeTimestamp = NSDate.Now;
        }

        #region View life cylce

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Disable fix on startup
            ApplyFixSwitch.SetState(true, false);

            UpdateGui();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            // Reload view when timezone change was detected
            _timeChangeObserver = NSNotificationCenter.DefaultCenter.AddObserver(UIApplication.SignificantTimeChangeNotification, OnSignificantTimeChangeNotification);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            _timeChangeObserver?.Dispose();
        }

        #endregion

        #region Events

        private void OnSignificantTimeChangeNotification(NSNotification notif)
        {
            Console.WriteLine("Received SignificantTimeChangeNotification");
            UpdateGui();
        }

        #endregion

        #region Button events

        partial void ApplyFixSwitch_ValueChanged()
        {
            UpdateGui();
        }

        #endregion

        #region Private methods

        private void UpdateGui()
        {
            if (ApplyFixSwitch.On)
            {
                // Local time zone data is cached after CurrentTimeZone is first used to retrieve time zone information.
                // If the system's local time zone subsequently changes, the CurrentTimeZone property does not reflect this change.
                // If you need to handle time zone changes while your application is running, use the TimeZoneInfo class and call its TimeZoneInfo.ClearCachedData method.
                // See: http://msdn.microsoft.com/en-us/library/system.timezone.currenttimezone(v=vs.110).aspx

                TimeZoneInfo.ClearCachedData();
            }
            
            xamarinTimeZoneLabel.Text = TimeZoneInfo.Local.StandardName;
            xamarinUtcTimeLabel.Text = _xamarinTimestamp.ToString("g");
            xamarinLocalTimeLabel.Text = _xamarinTimestamp.ToLocalTime().ToString("g");

            nativeTimeZoneLabel.Text = NSTimeZone.DefaultTimeZone.Abbreviation();

            var utcFormatter = new NSDateFormatter
            {
                DateStyle = NSDateFormatterStyle.Medium,
                TimeStyle = NSDateFormatterStyle.Short,
                TimeZone = NSTimeZone.FromAbbreviation("UTC")
            };
            nativeUtcTimeLabel.Text = utcFormatter.ToString(_nativeTimestamp);

            var localFormatter = new NSDateFormatter
            {
                DateStyle = NSDateFormatterStyle.Medium,
                TimeStyle = NSDateFormatterStyle.Short,
                TimeZone = NSTimeZone.SystemTimeZone
            };
            nativeLocalTimeLabel.Text = localFormatter.ToString(_nativeTimestamp);
        }

        #endregion 
    }
}