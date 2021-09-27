using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
namespace _2
{
    class Dog
    {
        /*public Dog()
        {
            Console.WriteLine("Class Dog");

        }*/
        /*private int i;
        public int I
        {
            get {
                if (i >= 10)
                {
                    return 20;
                }
                else
                {
                    return 5;
                }
                //return i;

            }
            set 
            {
                i = value;
            }
        }*/

    }
    /*class Animal:Dog
    {
        public Animal()
        {
            Console.WriteLine("Class Animal");

        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            /*var Obj1 = new Dog();
            Console.WriteLine("Enter i value");
            int x = Convert.ToInt32(Console.ReadLine());
            Obj1.I = x;
            Console.WriteLine(Obj1.I);*/
            var Data = new ArrayList();
            Console.WriteLine("Enter username to add in list");
            for (int index = 1; index <= 5; index++)
            {
                string Name = Console.ReadLine();
                Data.Add(Name);
            }
            for (int index = 0; index <Data.Count; index++)
            {
                Console.Write(Data[index]);
            }
               
            Console.ReadKey();
        }

    }
}
