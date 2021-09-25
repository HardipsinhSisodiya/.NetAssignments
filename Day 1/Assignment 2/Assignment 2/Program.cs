using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("Enter 1 for Addition ");
            Console.WriteLine("Enter 2 for Multiplication");
            Console.WriteLine("Enter 3 for Substraction");
            Console.WriteLine("Enter 4 for Division");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch(Choice)
            {
                case 1:
                    Console.WriteLine("Enter first number");
                    int FirstNumberAddition = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int SecondNumberAddition = Convert.ToInt32(Console.ReadLine());
                    int Addition = FirstNumberAddition + SecondNumberAddition;
                    Console.WriteLine("Addition of numbers is : " + Addition);
                    break;

                case 2:
                    Console.WriteLine("Enter first number");
                    int FirstNumberMultiplication = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int SecondNumberMultiplication = Convert.ToInt32(Console.ReadLine());
                    int Multiplication = FirstNumberMultiplication * SecondNumberMultiplication;
                    Console.WriteLine("Multiplication of numbers is : " + Multiplication);
                    break;

                case 3:
                    Console.WriteLine("Enter first number");
                    int FirstNumberSubstraction = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int SecondNumberSubstraction = Convert.ToInt32(Console.ReadLine());
                    int Substraction = FirstNumberSubstraction - SecondNumberSubstraction;
                    Console.WriteLine("Substraction of numbers is : " + Substraction);
                    break;

                case 4:
                    Console.WriteLine("Enter first number");
                    int FirstNumberDivision = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int SecondNumberDivision = Convert.ToInt32(Console.ReadLine());
                    int Division = FirstNumberDivision / SecondNumberDivision;
                    Console.WriteLine("Division of numbers is : " + Division);
                    break;

                default:
                    Console.WriteLine("Please enter any valid number");
                    break;
            }
            Console.ReadKey();
        }
    }
}
