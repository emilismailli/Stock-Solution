

namespace MHM.Accountancy.Business.Infrastructure.Utils
{
    public static partial class Grammer
    {
        static string[] onluqlar = { "on ", "iyirmi ", "otuz ", "qırx ", "əlli ", "altmış ", "yetmiş ", "səksən ", "doxsan " };

        static string[] teklikler = { "bir ", "iki ", "üç ", "dörd ", "beş ", "altı ", "yeddi ", "səkkiz ", "doqquz " };

        internal static string NumberAsWords(this long number)
        {
            string str = "";
            if (number < 0)
                str = "minus " + NumberAsWords(-number);
            else if (number != 0)
            {
                if (number >= 1 && number < 10)
                {
                    str = str + teklikler[number - 1] + NumberAsWords(number % 1);
                }
                else if (number >= 10 && number < 100)
                {
                    str = str + onluqlar[number / 10 - 1] + NumberAsWords(number % 10);
                }
                else if (number >= 100 && number < 1000)
                    str = str + NumberAsWords(number / 100) + "yüz " + NumberAsWords(number % 100);
                else if (number >= 1000 && number < 1000000)
                    str = str + NumberAsWords(number / 1000) + "min " + NumberAsWords(number % 1000);
                else if (number >= 1000000 && number < 1000000000)
                    str = str + NumberAsWords(number / 1000000) + "milyon " + NumberAsWords(number % 1000000);
                else if (number >= 1000000000 && number < 1000000000000)
                    str = str + NumberAsWords(number / 1000000000) + "milyard " +
                    NumberAsWords(number % 1000000000);
                else if (number >= 1000000000000 && number < 1000000000000000)
                    str = str + NumberAsWords(number / 1000000000000) + "trilyon " +
                    NumberAsWords(number % 1000000000000);
                else if (number >= 1000000000000000 && number < 1000000000000000000)
                    str = str + NumberAsWords(number / 1000000000000000) + "trilyard " +
                    NumberAsWords(number % 1000000000000000);
            }

            #region StartChecker
            if (str.StartsWith("minus bir yüz"))
            {
                str = str.Replace("minus bir yüz", "minus yüz");
            }
            else if (str.StartsWith("minus bir min"))
            {
                str = str.Replace("minus bir min", "minus min");
            }
            else if (str.StartsWith("bir yüz") || str.StartsWith("bir min"))
            {
                str = str.Remove(0, 4);
            }
            #endregion
            return str;
        }

        internal static string NumberAsWords(this byte number)
        {
            return NumberAsWords((long)number);
        }
    }
}
