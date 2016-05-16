using System;
using System.Configuration;

namespace RevStack.Commerce
{
    public static partial class Settings
    {
        public static int OrderKeyLength
        {
            get
            {
                string length = ConfigurationManager.AppSettings["Commerce.Order.Key.Length"];
                if (string.IsNullOrEmpty(length)) return 9;
                else return Convert.ToInt32(length);
            }
        }
        public static string PromotionInvalidMessage
        {
            get
            {
                string result = ConfigurationManager.AppSettings["Commerce.Promotion.Message.Invalid"];
                if (!string.IsNullOrEmpty(result)) return result;
                else return "Invalid promotion code";
            }
        }
        public static string PromotionLabel
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
