using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class Assignment2
    {
        public static bool IsValidBraces(string arithmeticString)
        {

            bool isValid = true;
            string onlyBraces = ExtractBraces(arithmeticString);

            while ((onlyBraces.Length != 0) && (onlyBraces.Contains("[]") || onlyBraces.Contains("()") || onlyBraces.Contains("{}")))
            {
                onlyBraces = onlyBraces.Replace("[]", "");
                onlyBraces = onlyBraces.Replace("()", "");
                onlyBraces = onlyBraces.Replace("{}", "");
            }

            if (onlyBraces.Length != 0)
            {
                isValid = false;
            }

            return isValid;
        }

        private static string ExtractBraces(string str)
        {
            int len = str.Length;

            var arr = str.ToCharArray();

            string filter = "";
            for (int i = 0; i < len; i++)
            {
                if ((arr[i] == '(') || (arr[i] == ')') || (arr[i] == '[') || (arr[i] == ']') || (arr[i] == '{') || (arr[i] == '}'))
                {
                    filter = filter + arr[i];
                }
            }
            return filter;
        }
    }
}
