using System;
using System.Collections.Generic;
using System.Text;

namespace WorkProject
{
    class NullCoalescing
    {

        static void Main(string[] args) {

            string str1 = null;
            string str2 = null;
            string str3 = null;
            string str4 = "first text";
            string str5 = "some text";

            string result = str1 ?? str2 ?? str3 ?? str4 ?? str5;


            Console.WriteLine(result);
        
        
        }
    }
}
