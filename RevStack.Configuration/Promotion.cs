using System;
using System.Configuration;

namespace RevStack.Configuration
{
    public static partial class Promotion
    {
        public static string InvalidMessage
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Commerce.Promotion.Message.Invalid"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "Invalid promotion code";
            }
        }
        public static string Label
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Commerce.Promotion.Label.Type"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "promotion";
            }
        }
    }
}
