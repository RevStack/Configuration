using System;
using System.Configuration;

namespace RevStack.Configuration
{
    public static partial class Order
    {
        public static int KeyLength
        {
            get
            {
                string length = ConfigurationManager.AppSettings["Order.Key.Length"];
                if (string.IsNullOrEmpty(length)) return 9;
                else return Convert.ToInt32(length);
            }
        }
        public static string EmailShipMessage
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Order.Email.ShipMessage"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "We’ll send a confirmation when your items ship";
            }
        }
        public static string EmailSubject
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Order.Email.Subject"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "Your Order Confirmation";
            }
        }
        public static string EmailAction
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Order.Email.Action"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "/Order/Email";
            }
        }
        public static string ConfirmationStatus
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Order.Confirmation.DefaultStatus"];
                if (!string.IsNullOrEmpty(result)) return result;
                return "Charged";
            }
        }
        public static string ConfirmationAlertKey
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Order.Confirmation.AlertKey"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "Payment Processing";
            }
        }
        public static string ConfirmationAlertValue
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Order.Confirmation.AlertValue"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "Credit card payment succussfully processed";
            }
        }
        public static string NotificationAction
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Order.Notification.Action"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "/Order/Notification";
            }
        }
        public static string NotificationLabel
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Order.Notification.Label"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "alert";
            }
        }
        public static string TrackingAction
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Order.Tracking.Action"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "/Order/Track";
            }
        }
        public static string TrackingUnauthenticatedAction
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Order.Tracking.Unauthenticated.Action"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "/Order/Track";
            }
        }
        public static string AdminTrackingUrl
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Order.Admin.Tracking.Url"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "/Order/Track";
            }
        }

    }
}
