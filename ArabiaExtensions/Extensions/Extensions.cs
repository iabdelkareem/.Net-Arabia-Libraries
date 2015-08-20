using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArabiaExtensions.Extensions
{
    public static class Extensions
    {
        private const char LRM = ((char)0x200E);

        #region Numeric
        public static string ToArabiaString(this byte e)
        {
            return Helpers.NumberToArabicString(e.ToString(CultureInfo.InvariantCulture));
        }

        public static string ToArabiaString(this sbyte e)
        {
            return Helpers.NumberToArabicString(e.ToString(CultureInfo.InvariantCulture));
        }

        public static string ToArabiaString(this short e)
        {
            return Helpers.NumberToArabicString(e.ToString(CultureInfo.InvariantCulture));
        }

        public static string ToArabiaString(this ushort e)
        {
            return Helpers.NumberToArabicString(e.ToString(CultureInfo.InvariantCulture));
        }

        public static string ToArabiaString(this int e)
        {
            return Helpers.NumberToArabicString(e.ToString(CultureInfo.InvariantCulture));
        }

        public static string ToArabiaString(this uint e)
        {
            return Helpers.NumberToArabicString(e.ToString(CultureInfo.InvariantCulture));
        }

        public static string ToArabiaString(this long e)
        {
            return Helpers.NumberToArabicString(e.ToString(CultureInfo.InvariantCulture));
        }

        public static string ToArabiaString(this ulong e)
        {
            return Helpers.NumberToArabicString(e.ToString(CultureInfo.InvariantCulture));
        }

        public static string ToArabiaString(this double e)
        {
            return Helpers.NumberToArabicString(e.ToString(CultureInfo.InvariantCulture));
        }

        public static string ToArabiaString(this float e)
        {
            return Helpers.NumberToArabicString(e.ToString(CultureInfo.InvariantCulture));
        }

        public static string ToArabiaString(this decimal e)
        {
            return Helpers.NumberToArabicString(e.ToString(CultureInfo.InvariantCulture));
        }

        #endregion

        #region DateTime

        public static string ToArabiaString(this DateTime e, string format = "tt hh:mm yyyy-MM-dd ddd")
        {
            StringBuilder formattedDateBuilder = new StringBuilder(format);

            formattedDateBuilder.Replace("yyyy", LRM + Helpers.NumberToArabicString(e.Year.ToString()));

            formattedDateBuilder.Replace("yyy", LRM + Helpers.NumberToArabicString(e.Year.ToString().Substring(1, 3)));

            formattedDateBuilder.Replace("yy", LRM + Helpers.NumberToArabicString(e.Year.ToString().Substring(2, 2)));

            formattedDateBuilder.Replace("MMMM", LRM + Helpers.MonthNameResolver(e.Month));

            formattedDateBuilder.Replace("MMM", LRM + Helpers.MonthNameResolver(e.Month));

            formattedDateBuilder.Replace("MM", e.Month > 9 
                ? LRM + Helpers.NumberToArabicString(e.Month.ToString()) 
                : LRM + "٠" + Helpers.NumberToArabicString(e.Month.ToString()));

            formattedDateBuilder.Replace("M", LRM + Helpers.NumberToArabicString(e.Month.ToString()));

            formattedDateBuilder.Replace("dddd", LRM + Helpers.DayNameResolver(e.DayOfWeek) + LRM);

            formattedDateBuilder.Replace("ddd", LRM + Helpers.DayNameResolver(e.DayOfWeek) + LRM);

            formattedDateBuilder.Replace("dd",
                e.Day > 9
                    ? LRM + Helpers.NumberToArabicString(e.Day.ToString())
                    : LRM + "٠" + Helpers.NumberToArabicString(e.Day.ToString()));

            formattedDateBuilder.Replace("d", LRM + Helpers.NumberToArabicString(e.Day.ToString()));

            formattedDateBuilder.Replace("HH",
                e.Hour > 9
                    ? LRM + Helpers.NumberToArabicString(e.Hour.ToString())
                    : LRM + "٠" + Helpers.NumberToArabicString(e.Hour.ToString()));

            formattedDateBuilder.Replace("H", LRM + Helpers.NumberToArabicString(e.Hour.ToString()));

            formattedDateBuilder.Replace("hh",
                (e.Hour%12) > 9
                    ? LRM + Helpers.NumberToArabicString((e.Hour%12).ToString())
                    : LRM + "٠" + Helpers.NumberToArabicString((e.Hour%12).ToString()));

            formattedDateBuilder.Replace("h", Helpers.NumberToArabicString((e.Hour%12).ToString()));

            formattedDateBuilder.Replace("mm",
                e.Minute > 9
                    ? LRM + Helpers.NumberToArabicString(e.Minute.ToString())
                    : LRM + "٠" + Helpers.NumberToArabicString(e.Minute.ToString()));

            formattedDateBuilder.Replace("m", LRM + Helpers.NumberToArabicString(e.Minute.ToString()));

            formattedDateBuilder.Replace("ss",
                e.Second > 9
                    ? LRM + Helpers.NumberToArabicString(e.Second.ToString())
                    : LRM + "٠" + Helpers.NumberToArabicString(e.Second.ToString()));

            formattedDateBuilder.Replace("s", LRM + Helpers.NumberToArabicString(e.Second.ToString()));

            formattedDateBuilder.Replace("tt", e.Hour >= 12 ? LRM + "صباحاً" + LRM : "مساءَ" + LRM);

            formattedDateBuilder.Replace("t", e.Hour >= 12 ? LRM + "ص" + LRM : "م" + LRM);
            
            return formattedDateBuilder.ToString();
        }

        #endregion



    }
}
