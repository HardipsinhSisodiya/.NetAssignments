using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Row = new int[50, 50];
            int[,] Column = new int[50, 50];

            Console.WriteLine("Enter rows number");
            int Rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter columns number");
            int Columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter matrix values");
            for(int RowIndex=0; RowIndex<Rows; RowIndex++)
            {
                for (int ColumnIndex = 0; ColumnIndex < Columns; ColumnIndex++)
                {
                    Console.WriteLine("Element [{0}], [{1}]", RowIndex, ColumnIndex);
                    Row[RowIndex, ColumnIndex] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix is: ");
            for (int RowIndex = 0; RowIndex < Rows; RowIndex++)
            {
                Console.WriteLine("\n");
                for (int ColumnIndex = 0; ColumnIndex < Columns; ColumnIndex++)
                {
                    Console.Write("[{0}]\t", Row[RowIndex, ColumnIndex]);
                }
            }


            for (int RowIndex = 0; RowIndex < Rows; RowIndex++)
            {
                for (int ColumnIndex = 0; ColumnIndex < Columns; ColumnIndex++)
                {
                    Column[ColumnIndex,RowIndex] = Row[RowIndex, ColumnIndex] ;
                }
            }

            Console.WriteLine("\nTranspose of Matrix");
            for (int RowIndex = 0; RowIndex < Rows; RowIndex++)
            {
                Console.WriteLine("\n");
                for (int ColumnIndex = 0; ColumnIndex < Columns; ColumnIndex++)
                {
                    Console.Write("[{0}]\t", Column[RowIndex, ColumnIndex]);
                }
            }
            Console.ReadKey();

        }
    }
}
