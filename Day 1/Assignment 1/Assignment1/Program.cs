using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Maths marks");
            Double MathsMarks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Science marks");
            Double PhysicsMarks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Chemistry marks");
            Double ChemistryMarks = Convert.ToDouble(Console.ReadLine());
            Double Average;
            Average = (MathsMarks + PhysicsMarks + ChemistryMarks) / 3;
            Console.WriteLine("Average= "+Average);
            if (Average >90)
                Console.WriteLine("Grade A");
            if (Average > 80 && Average <= 90)
                Console.WriteLine("Grade B");
            if (Average > 70 && Average <= 80)
                Console.WriteLine("Grade C");
            if (Average >= 35 && Average <= 70)
                Console.WriteLine("Grade D");
            if (Average < 35)
                Console.WriteLine("Grade F");
            Console.ReadKey();
        }
    }
}
