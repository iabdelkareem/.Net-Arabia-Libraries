using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("ArabiaMvc")]
namespace ArabiaExtensions
{
    internal static class Helpers
    {
        private static readonly string[] ArabianNumbers;

        private static readonly string[] ArabianMonths;

        private static readonly Dictionary<DayOfWeek, string> ArabianDays; 
        static Helpers()
        {
            ArabianNumbers = new string[]
            {
                "٠‎","١","‎٢","‎٣","‎٤","‎٥","‎٦","‎٧","‎٨","‎٩‎"
            };

            ArabianMonths = new string[]
            {
                "يناير",
                "فبراير",
                "مارس",
                "إبريل",
                "مايو",
                "يونيه",
                "يوليه",
                "أغسطس",
                "سبتمبر",
                "أكتوبر",
                "نوفمبر",
                "ديسمبر"
            };

            ArabianDays = new Dictionary<DayOfWeek, string>();
            ArabianDays.Add(DayOfWeek.Friday, "الجمعة");
            ArabianDays.Add(DayOfWeek.Saturday, "السبت");
            ArabianDays.Add(DayOfWeek.Sunday, "الأحد");
            ArabianDays.Add(DayOfWeek.Monday, "الأثنين");
            ArabianDays.Add(DayOfWeek.Tuesday, "الثلاثاء");
            ArabianDays.Add(DayOfWeek.Wednesday, "الأربعاء");
            ArabianDays.Add(DayOfWeek.Thursday, "الخميس");
        }

        internal static string NumberToArabicString(string obj)
        {
            var latinNumbers = obj.ToCharArray();
            bool isNegative = latinNumbers[0] == '-';

            StringBuilder arabianNumbers = new StringBuilder();
            for (int c = (isNegative ? 1 : 0) ; c < latinNumbers.Length; c++)
            {
                arabianNumbers.Append(NumberConverter(latinNumbers[c]));
            }
            if (isNegative)
                arabianNumbers.Append('-');
            return arabianNumbers.ToString();
        }

        private static string NumberConverter(char input)
        {
            int number;
            bool isNumber = int.TryParse(input.ToString(), out number);
            if (isNumber)
                return ArabianNumbers[number];
            if (input == '.')
                return ",";


            return "";
        }

        internal static string MonthNameResolver(int month)
        {
            return ArabianMonths[month - 1];
        }

        internal static string DayNameResolver(DayOfWeek day)
        {
            return ArabianDays[day];
        }
    }
}
