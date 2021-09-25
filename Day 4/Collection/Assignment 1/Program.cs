using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Calculator
    {
        public static int Add(int Num1,int Num2)
        {
            Console.WriteLine("Addition= "+(Num1 + Num2));
            return Num1 + Num2;
        }
        public static int Substract(int Num1, int Num2)
        {
            Console.WriteLine("Substraction= " + (Num1 - Num2));
            return Num1-Num2;
        }
        public static int Multiply(int Num1, int Num2)
        {
            Console.WriteLine("Multiplication= " + (Num1 * Num2)); 
            return Num1 * Num2;
        }
        public static int Devide(int Num1, int Num2)
        {
            Console.WriteLine("Division= " + (Num1 / Num2)); 
            return Num1 / Num2;
        }
    }
    class Program
    {
        public delegate int CalculatorDelegator(int Num1,int Num2);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int Num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            //Calculator Obj = new Calculator();
            CalculatorDelegator Calc = new CalculatorDelegator(Calculator.Add);
            Calc += Calculator.Substract;
            Calc += Calculator.Multiply;
            Calc += Calculator.Devide;
            Calc(Num1, Num2);
            Console.ReadKey();
        }
    }
}
