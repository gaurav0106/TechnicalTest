using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class Assignment1
    {
        int factorial(int n)
        {
            if (n == 0) return 1;
            return n * factorial(n);
            /*Above line should not pass 'n' as this would lead to an 
             infinite recursive call, instead it should pass 'n-1'*/  
        }
    }
}
