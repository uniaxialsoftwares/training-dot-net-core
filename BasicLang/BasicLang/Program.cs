﻿using System;

namespace BasicLang
{
    class Program
    {
        static void Main(string[] args)
        {
            // single line comment
            /*
              i am multiline 
              comment
              */
            // variables   TYPE Identifier
            // Numeric int, float, double, decimal
            int a=100;
            int b;
            int c=10, d=9, e=200;
             
            // value assign  =
            b = 100;
            int sum = a + b + c;
            int expr = a - (b + c);
            float result = a/10;
            Console.Write("The result of a/10="+ result+"\n");
            // Character: char, string
            char x = 'A';
            

            // string operation
            string firstName = "Ram";
            string lastName = "Nepal";
            string fullName = firstName +" "+ lastName;
            Console.WriteLine(fullName);
            
            // bool : true, false
            bool isPass = true;

            // Assignment
            int m = 10;
            int n = 2;

            // The operation 10/2=5
            float res = m / n;
            Console.WriteLine("The Operation " + m + "/" + n + "=" + res);

            Console.WriteLine(isPass);
            Console.Read();
        }
    }
}
