using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Web;


namespace BackOffice.Helper
{
    public static class Helper
    {
        public static DateTime Parse(this string date)
        {
            return DateTime.ParseExact(date, Constants.ApplicationDateFormat, CultureInfo.InvariantCulture);
        }
        public static string ParseToApplicationDateFormat(this DateTime? date)
        {
            return date?.ToString(Constants.ApplicationDateFormat);
        }   
        public static string ToFranceDateString(this DateTime? date)
        {
            return date.HasValue ? date.Value.ToString(Constants.ApplicationDateFormat, DateTimeFormatInfo.InvariantInfo) : string.Empty;
        }
        public static string GetQueryString(this object obj)
        {
            var result = new List<string>();
            foreach (PropertyDescriptor p in TypeDescriptor.GetProperties(obj))
            {
                var value = p.GetValue(obj);
                if (value != null)
                {
                    if (p.PropertyType == typeof(DateTime?))
                    {
                        result.Add(p.Name + "=" +  ((DateTime?)value).ToFranceDateString());
                    }
                    else
                    {
                        result.Add(p.Name + "=" + HttpUtility.UrlEncode(value.ToString()));
                    }
                }
            }
            return "?"+string.Join("&", result);
        }
    }
}