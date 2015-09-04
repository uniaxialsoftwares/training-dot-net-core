using System;

namespace BasicLang
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Day 1:
             *
            // SIngle line comment
            ///*
            // * I am a multiline
            // * comment
             // *

            //variable : type name

            // Numeric: int float double decimal
            int a;
            int b=20, c;

            //Assignment =
            a = 100;
            int x = 100,
                y = 19;


            int sum = a + x;
            float div = a / x;
            Console.WriteLine("5*10/2:" + (5.0 *  2.0 / 3.0-2  ));

            int total = sum - (a + b);

            Console.WriteLine(div);
            Console.WriteLine("The sum of a and x =" + sum);

            // variable: character: char string
            char chr = 'A';
            string firstName = "Ram";
            string lastName = "Nepal";

            string fullName = firstName +" "+ lastName;

            Console.Write(fullName+"\n");

            //variable bool: true flase
            bool isStudent;
            isStudent = true;
            Console.WriteLine(isStudent);
            */


            // Day 2
            // Conditionals

            // if-else, if - elseif
            int a = 10, b = 10;
            bool isClassRunning = true;
            bool isPhoneBusy = true;

            if (isClassRunning == true )
            {
                if (isPhoneBusy)
                {
                    Console.WriteLine("Hi! I am busy on Phone");
                }
                else
                {
                    Console.WriteLine("Hi! I am from Class");
                }
            }
            else
            {
                Console.WriteLine("Hi! from cafe");
            }

            float percent = 89;
            string result = "";
            bool isFeeDue = true;
            if (isFeeDue)
            {
                Console.WriteLine("Please clear dues");
            }
            else
            {
                if (percent < 40)
                {
                    result = "Fail";
                }
                else if (percent < 60)
                {
                    result = "Pass Div";
                }
                else if (percent < 80)
                {
                    result = "First Div";
                }
                else
                {
                    result = "Distinction";
                }
                Console.WriteLine("Your Result is : " + result);
            }


            // Loop: Iteration
            int num = 7;
            for (int i = 1; i <= 10; i++ )
            {
                //Console.WriteLine("Inside loop");
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }

            string input = Console.ReadLine();
            int input_int = Convert.ToInt32(input);

            //Console.WriteLine("Your input is:" + input.ToUpper());
            Console.WriteLine(input_int);

                Console.Read();


        }
    }
}
