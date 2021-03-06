using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumber
{
    static class Roman
    {
        static string[] roman1 = { "MMM", "MM", "M" };
        static string[] roman2 = { "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C" };
        static string[] roman3 = { "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X" };
        static string[] roman4 = { "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };

        public static bool TryParse(string text, out int value)
        {
            value = 0;
            if (String.IsNullOrEmpty(text)) return false;
            text = text.ToUpper();
            int len = 0;

            for (int i = 0; i < 3; i++)
            {
                if (text.StartsWith(roman1[i]))
                {
                    value += 1000 * (3 - i);
                    len = roman1[i].Length;
                    break;
                }
            }

            if (len > 0)
            {
                text = text.Substring(len);
                len = 0;
            }

            for (int i = 0; i < 9; i++)
            {
                if (text.StartsWith(roman2[i]))
                {
                    value += 100 * (9 - i);
                    len = roman2[i].Length;
                    break;
                }
            }

            if (len > 0)
            {
                text = text.Substring(len);
                len = 0;
            }

            for (int i = 0; i < 9; i++)
            {
                if (text.StartsWith(roman3[i]))
                {
                    value += 10 * (9 - i);
                    len = roman3[i].Length;
                    break;
                }
            }

            if (len > 0)
            {
                text = text.Substring(len);
                len = 0;
            }

            for (int i = 0; i < 9; i++)
            {
                if (text.StartsWith(roman4[i]))
                {
                    value += 9 - i;
                    len = roman4[i].Length;
                    break;
                }
            }

            if (text.Length > len)
            {
                value = 0;
                return false;
            }

            return true;
        }
        public static string ToRoman(int num)
        {
            if (num > 3999) throw new ArgumentException("Too big");
            if (num < 1) throw new ArgumentException("Too small");
            int thousands, hundreds, tens, units;
            thousands = num / 1000;
            num %= 1000;
            hundreds = num / 100;
            num %= 100;
            tens = num / 10;
            units = num % 10;
            var sb = new StringBuilder();
            if (thousands > 0) sb.Append(roman1[3 - thousands]);
            if (hundreds > 0) sb.Append(roman2[9 - hundreds]);
            if (tens > 0) sb.Append(roman3[9 - tens]);
            if (units > 0) sb.Append(roman4[9 - units]);
            return sb.ToString();
        }
    }
}
