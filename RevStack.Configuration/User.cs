using System;
using System.Configuration;

namespace RevStack.Configuration
{
    public static partial class User
    {
        public static string NotificationAction
        {
            get
            {
                string result = ConfigurationManager.AppSettings["User.Notification.Action"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "/User/Notification";
            }
        }
        public static string NotificationLabel
        {
            get
            {
                string result = ConfigurationManager.AppSettings["User.Notification.Label"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "message";
            }
        }
        public static string SignInAction
        {
            get
            {
                string result = ConfigurationManager.AppSettings["User.SignIn.Action"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "/Identity/Sign-In";
            }
        }
        public static string SignUpAction
        {
            get
            {
                string result = ConfigurationManager.AppSettings["User.SignUp.Action"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "/Identity/Sign-Up";
            }
        }
        public static string SignUpKey
        {
            get
            {
                string result = ConfigurationManager.AppSettings["User.SignUp.Alert.Key"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "Sign Up Confirmation";
            }
        }
        public static string SignUpValue
        {
            get
            {
                string result = ConfigurationManager.AppSettings["User.SignUp.Alert.Value"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "You have successfully registered your account!";
            }
        }
    }
}
