using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class Assignment4
    {
        public static char[] Flatten(char[] array)
        {
            StringBuilder builder = new StringBuilder();

            foreach (char item in array)
            {
                if (Char.IsDigit(item))
                {
                    builder.Append(item);
                }
            }

            return builder.ToString().ToCharArray();
        }

        public void Flatten_ValidArray()
        {
            var array = new char[] { '(', '1', '2', '3', '3', ')' };

            Flatten(array);
        }
    }

}
