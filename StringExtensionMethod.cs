using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcore
{
    public static class StringExtensionMethod
    {
     public static int CountSpaces(this string text)
        {
            int count = 0;
            foreach (var item in text)
            {
                if (item == ' ')
                {
                    count++;
                }
            }
            return count;
        }
       

    }
}
