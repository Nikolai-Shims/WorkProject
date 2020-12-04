using System;
using System.Collections.Generic;
using System.Text;

namespace WorkProject
{
    class NamedArgument
    {
        static void Main(string[] args)
        {

            PrintDetail(age: 31, description: "Aqa Engineer", text: "simple text");
        }

        public static void PrintDetail(string text, int age, string description)
        {
            Console.WriteLine($"People who work as {description}, and {age} years old, have some description {text}");
        }
    }
}
