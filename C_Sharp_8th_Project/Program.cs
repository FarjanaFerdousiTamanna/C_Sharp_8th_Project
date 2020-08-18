using System;

namespace C_Sharp_8th_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // parsing 
            string num = "2";
            int num2 = Int32.Parse(num);
            Console.WriteLine(num);

            //taking value from user by reading it through console
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int num3 = Int32.Parse(age);
            int newage = num3 + 5;

            Console.WriteLine("Your age in 5 years is going to be " + newage);




        }
    }
}
