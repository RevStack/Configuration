using System;
using System.Configuration;

namespace RevStack.Configuration
{
    public static partial class Html
    {
        public static string HighlightColor
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Html.Email.HighlightColor"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "#2fbd51";
            }
        }
        public static string LinkColor
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Html.Email.LinkColor"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "#5fb3f6";
            }
        }
    }
}
