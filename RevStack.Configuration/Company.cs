using System;
using System.Configuration;

namespace RevStack.Configuration
{
    public static partial class Company
    {
        public static string Name
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Company.Name"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "My Company";
            }
        }
        public static string Address
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Company.Address"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "";
            }
        }
        public static string Phone
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Company.Phone"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "";
            }
        }
        public static string LogoUrl
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Company.LogoUrl"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "";
            }
        }
        public static string NotificationEmail
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Company.Notification.Email"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "dev.null@localhost";
            }
        }
        public static string NotificationSms
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Company.Notification.Sms"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "0000000000";
            }
        }
        public static string NotificationRecipientEmail
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Company.Notification.RecipientEmail"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "dev.null@localhost";
            }
        }
        public static string NotificationRecipientSms
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Company.Notification.RecipientSms"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "0000000000";
            }
        }
    }
}
