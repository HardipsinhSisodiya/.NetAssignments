using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string NameFound="";
            string[] Names =new string[10];
            int StringCompare = 1;
            for (int NameIndex = 0; NameIndex < Names.Length; NameIndex++)
            {
                Console.WriteLine($"Enter "+ NameIndex +" name");
                Names[NameIndex] = Console.ReadLine();
            }
            Console.WriteLine($"Enter the name you want to search:");
            string SearchName=Console.ReadLine();

            
            for (int NameIndex = 0; NameIndex < Names.Length; NameIndex++)
            {  
                if (SearchName == Names[NameIndex])
                {
                    StringCompare = 0;
                }
                if (StringCompare == 0)
                {
                    NameFound = Names[NameIndex];
                    break;
                }
            }
            if(StringCompare == 0)
            {
                Console.WriteLine($"{NameFound} name found ");
            }
            else
            {
                Console.WriteLine("Name not found");
            }
        Console.ReadKey();
        }
    }
}
