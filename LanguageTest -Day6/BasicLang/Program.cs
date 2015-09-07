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

            /*
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
           */

            /*
            // Switch: int ,char
            char Input = '8';
            switch (Input)
            {
                case 'A':
                    Console.WriteLine("I am inside Switch and case is A ");
                    break;
                case 'B':
                    Console.WriteLine("I am inside Switch and case is B ");
                    break;
                default:
                    Console.WriteLine("I am inside Switch and Default Case ");
                    break;

            }




            // Loop: Iteration
            int num = 8;
            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine("Inside loop");
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }

            // while
            // int num;
            
            string option = "";

            do
            {
                Console.Write("Enter Any Number to generate table:");

                // number input
                string inputNumber = Console.ReadLine();
                num = Convert.ToInt32(inputNumber);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(num + " x " + j + "=" + (num * j));
                }
                Console.Write("Do you want to continue [Y/N]:");
                option = Console.ReadLine();
                //option = option.ToUpper();
                //option = option.Trim();
                option = option.Trim().ToUpper();
            } while (option == "Y" || option == "YES");



            // Array
            string[] names = new string[6];
            string[] address = {"","","","","","" };
            address[3] = "Balaju";
            int[] nums = { 9, 34, 30, 324, 38984, 0 }; // int[] nums = new int[6];
            Console.WriteLine("The value of num[3]" + nums[3]);
            Console.WriteLine("The value of adress[3]" + address[3]);





            //Reading Input in console

            //string input = Console.ReadLine();
            //int input_int = Convert.ToInt32(input);

            ////Console.WriteLine("Your input is:" + input.ToUpper());
            //Console.WriteLine(input_int);

            Console.Read();
            */

        // Day 5
/*
            // Class and object

            // object declaration
            Fan electroMax;
            // init
            electroMax = new Fan();
            //setting data to variables
            electroMax.WingsCount = 3;
            electroMax.Manufacturer = "Electro Max Inc.";

            // dec + init
            Fan belkin = new Fan();
            belkin.Manufacturer = "Belkin";
            belkin.WingsCount = 4;

            //electroMax.height = 12;
            //electroMax.speed = 1232;
            ////electroMax.costPrice = 299;
            
            //// accessing data
            //int wings = electroMax.noOfWings;
            //float speed = electroMax.speed;
            ////Console.WriteLine("No of wings of electroMax is: " + wings);
            //// The speed of electromax fan having no of wings ..... is .....
            //Console.WriteLine("The speed of electromax fan having no of wings " + wings + " is " + electroMax.speed + "");

*/


           // Day6
            Fan objFan1 = new Fan();
            Fan objFan2 = new Fan("ElectroMax", 3);
            Fan objFan3 = new Fan("Digitech", 4, 1200);
            objFan1.Manufacturer = "ABC";
            objFan1.SwitchOn();
            objFan1.SpeedChange(-100);
            objFan1.SpeedDown();
                objFan1.SpeedUp(); 
            objFan1.SpeedDown();
            Console.WriteLine("The State of objFan1 is:+" + objFan1.IsRunning + " and Current Speed is :"+ objFan1.CurrentSpeed);

            Console.Read();

        }
    }
}
