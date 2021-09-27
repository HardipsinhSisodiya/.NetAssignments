/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List working
            *//*Console.WriteLine("Enter number");
            //float x=Convert.ToInt32(Console.ReadLine());
            //int[] Score = new int[5];
            List<int> Score = new List<int>();
            for(int Index=1;Index<=5;Index++)
            {
                Console.WriteLine($"Enter {Index} Mumber");
                int x=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x);
                Score.Add(x);
                //Score.Add(x);
            }
            for (int Index = 0; Index < Score.Count; Index++)
            {
                Console.Write(Score[Index]);
            }*//*
            //Array working
            *//*Console.WriteLine("Enter number");
            double[] Score = new double[5];
            for(int Index=0;Index<Score.Length;Index++)
            {
                Console.WriteLine($"Enter {Index+1} Number");
                Score[Index] = Convert.ToDouble(Console.ReadLine());

            }
            *//*for (int I = 0; I < Score.Length; I++)
            {
                Console.Write(Score[I]+"\t");
            }*//*
            foreach(int i in Score)
            {
               Console.Write(i+"\t");
            }*/
/*Console.WriteLine("Enter Row size");
int RowSize = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Column size");
int ColumnSize = Convert.ToInt32(Console.ReadLine());

int[,] RowValue = new int[RowSize,ColumnSize];
//int[,] ColumnValue = new int[2,2];

for(int Row=0;Row<RowValue.GetLength(0);Row++)
{
    for(int Column=0;Column<RowValue.GetLength(1);Column++)
    {
        Console.WriteLine($"enter number ={Row}...{Column}");
        RowValue[Row,Column] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}
for (int Row = 0; Row < RowValue.GetLength(0); Row++)
{
    for (int Column = 0; Column < RowValue.GetLength(1); Column++)
    {
        Console.Write(RowValue[Row, Column]+"\t");
    }
    Console.WriteLine();
}*//*

var Data = new Dictionary<string, string>();
for (int Index = 0;Index < 5; Index++)
{
    Console.WriteLine($"Enter {Index} Name");
    string DataNumber = Console.ReadLine();
    string DataName = Console.ReadLine();
    Data.Add(DataNumber,DataName);
}
foreach(string i in Data.Keys)
{
    Console.Write(i+"\t");
}
foreach (string i in Data.Values)
{
    Console.Write(i + "\t");
}
Console.ReadKey();
}
}
}
*//*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_LamdaExpression
{
    public delegate void PrintHello();
    public delegate void SayHello(string username);
    public delegate string GetHello(string username);
    class Program
    {
        static void Main(string[] args)
        {
           *//* var Obj1 = new PrintHello(Method1);
            Obj1();*//*


            //PrintHello Obj2 = () => Console.WriteLine("Hello from Lamda");
          *//*  PrintHello Obj2 = () =>
            {
                Console.WriteLine("Hello from Lamda");
                Console.WriteLine("This is second line of code");
            };
            Obj2();*//*



            Console.WriteLine("Enter your name");
            string input = Console.ReadLine();

            SayHello Obj3 = u => Console.WriteLine("Hello : " + u);
            Obj3(input);


            *//*GetHello Obj4 = x => "Hello there " + x;
            var output = Obj4(input);
            Console.WriteLine(output);*//*

            Console.ReadKey();
        }
        static void Method1()
        {
            Console.WriteLine("Hello from method1");
        }
    }
}*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_LINQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double Salary { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name, string city, DateTime dt, double sal)
        {
            this.Id = id;
            this.Name = name;
            this.City = city;
            this.DateOfJoining = dt;
            this.Salary = sal;
        }
        public override string ToString()
        {
            return $"Id={this.Id}, Name={this.Name}, City={this.City}, DOJ={this.DateOfJoining.ToShortDateString()}, Salary={this.Salary}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Obtain data source
            var Data = GetEmployees();

            //Create query
            //select * from Employees
            //var Query = from obj in Data
            //            select obj;

            var Query = from obj in Data
                        orderby obj.Name ascending
                        select obj;
            //Console.WriteLine();
            foreach (var Output in Query)
            {
                Console.WriteLine(Output);
            }

            //select * from employees order by name
            //var Query = from obj in Data
            //            orderby obj.Name
            //            select obj;


            //select * from employees order by city, salary asc
            //var Query = from obj in Data
            //            orderby obj.City, obj.Salary descending
            //            select obj;


            //select * from employees where salary > 25000
            //var Query = from obj in Data
            //            orderby obj.Salary
            //            where obj.Salary > 25000
            //            select obj;


            //select * from employees where salary > 30000 and city = 'pune'
            //var Query = from obj in Data
            //            where obj.Salary > 3000 && obj.City == "Pune"
            //            select obj;

            //select * from employees where name like 'A%'
            //var Query = from obj in Data
            //            where obj.Name.StartsWith("A")
            //            select obj;

            //Execute query
            //foreach (var item in Query)
            //{
            //    Console.WriteLine(item);
            //}


            //select sum(salary) from Employees
            //var TotalSalary = Data.Sum(e => e.Salary);
            //Console.WriteLine("Total salary = " + TotalSalary);

            //Display employee with highest salary
            //var HighestSalary = (from obj in Data
            //                     orderby obj.Salary descending
            //                     select obj).FirstOrDefault();
            //if (HighestSalary != null)
            //    Console.WriteLine(HighestSalary);


            //Display employee with second highest salary
            /* var SecondHighestSalary = (from obj in Data
                                        orderby obj.Salary descending
                                        select obj).Skip(1).FirstOrDefault();
             if (SecondHighestSalary != null)
                 Console.WriteLine(SecondHighestSalary);*/




            Console.ReadKey();
        }
        static List<Employee> GetEmployees()
        {
            var employees = new List<Employee>()
            {
                new Employee(101,"Jojo", "Pune", new DateTime(2015, 01, 10), 50000),
                new Employee(102,"Aathma", "Kochin", new DateTime(2010, 12, 10), 70000),
                new Employee(103,"Sara", "Pune", new DateTime(2015, 05, 10), 45000),
                new Employee(104,"Bob", "Delhi", new DateTime(2020, 12, 10), 20000),
                new Employee(105,"John", "Hyderabad", new DateTime(2015, 01, 10), 35000),
            };
            return employees;
        }
    }
}