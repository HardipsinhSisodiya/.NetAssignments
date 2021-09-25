using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Employee:IComparable<Employee>
    {
        public int ID;
        public string CustomerName;
        public string Email;
        public int Salary;
        public string Location;
        public int CompareTo(Employee other)
        {
            return this.ID.CompareTo(other.ID);
        }
        public override string ToString()
        {
            return $"{this.ID}\t\t{this.CustomerName}\t\t{this.Email}\t\t{this.Salary}\t\t{this.Location}";
        }
    }
    class Program
    {
        static List<Employee> EmployeeList= new List<Employee>();
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.ID = 1;
            employee.CustomerName = "Hardip";
            employee.Email = "a@gmail.com";
            employee.Salary = 1000;
            employee.Location = "A";
            EmployeeList = new List<Employee>()
             {
                 employee,
                // new Employee(){ }
             };
            while (true)
            {
                try
                {

                    Console.WriteLine("Enter your choice what you want to do");
                    Console.WriteLine("1.Add an employee");
                    Console.WriteLine("2.List all employee");
                    Console.WriteLine("3.Delete an employee");
                    Console.WriteLine("4.Update an employee");
                    Console.WriteLine("5.Search an employee by ID");

                    int Choice = Convert.ToInt32(Console.ReadLine());

                    switch (Choice)
                    {
                        case 1:
                            AddEmployee();
                            break;
                        case 2:
                            DisplayEmployee();
                            break;
                        case 3:
                            RemoveEmployee();
                            Console.WriteLine("After deleting employee");
                            DisplayEmployee();
                            break;
                        case 4:
                            UpdateEmployee();
                            break;
                        case 5:
                            SearchEmployee();
                            break;
                        default:
                            Console.WriteLine("Enter valid choice");
                            break;
                    }

                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine("Enter valid details");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter valid details");
                }
            }
        }
            private static void AddEmployee()
            {
                var EmployeeToAdd = new Employee();
                Console.WriteLine("Enter your ID");
                EmployeeToAdd.ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your name");
                EmployeeToAdd.CustomerName = Console.ReadLine();

                Console.WriteLine("Enter your email");
                EmployeeToAdd.Email = Console.ReadLine();

                Console.WriteLine("Enter your salary");
                EmployeeToAdd.Salary = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your location");
                EmployeeToAdd.Location = Console.ReadLine();
                EmployeeList.Add(EmployeeToAdd);
            }

            private static void DisplayEmployee()
            { 
                foreach(var emp in EmployeeList)
                {
                    Console.WriteLine(emp.ToString());
                }
            }

            private static void RemoveEmployee()
            {
                int IDToSearch = -1;
                Console.WriteLine("Enter the id to search");
                IDToSearch = Convert.ToInt32(Console.ReadLine());

                bool IsFound = false;
                foreach (var emp in EmployeeList)
                {
                    if (emp.ID == IDToSearch)
                    {
                        Console.WriteLine("Employee found");
                        Console.WriteLine(emp.ToString());
                        EmployeeList.Remove(emp);
                        IsFound = true;
                        break;
                    }
                }
                if (!IsFound)
                Console.WriteLine("Employee not found for Id = {0}", IDToSearch);
            }
        private static void UpdateEmployee()
        {
            Console.WriteLine("Enter id to search employee details");
            int ID = Convert.ToInt32(Console.ReadLine());
            Boolean IsFound = false;
            foreach(var emp in EmployeeList)
            {
                if(emp.ID== ID )
                {
                    var EmployeeToAdd = new Employee();
                    Console.WriteLine("Employee Found");
                    Console.WriteLine(emp.ToString());
                    EmployeeList.Remove(emp);
                    Console.WriteLine("Enter your new ID");
                    EmployeeToAdd.ID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your new name");
                    EmployeeToAdd.CustomerName = Console.ReadLine();

                    Console.WriteLine("Enter your new email");
                    EmployeeToAdd.Email = Console.ReadLine();

                    Console.WriteLine("Enter your new salary");
                    EmployeeToAdd.Salary = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your new location");
                    EmployeeToAdd.Location = Console.ReadLine();
                    EmployeeList.Add(EmployeeToAdd);
                    IsFound = true;
                    //DisplayEmployee();
                }
            }
            //DisplayEmployee();
            if (!IsFound)
            {
                Console.WriteLine("Employee not found");
            }
        }
        private static void SearchEmployee()
        {
            Console.WriteLine("Enter id to search employee details");
            int ID = Convert.ToInt32(Console.ReadLine());
            Boolean IsEmployeeFound = false;
            foreach (var emp in EmployeeList)
            {
                if (emp.ID == ID)
                {
                    Console.WriteLine("Employee found");
                    Console.WriteLine(emp.ToString());
                    IsEmployeeFound = true;
                }
            }
            if(!IsEmployeeFound)
            {
                Console.WriteLine("Employee Not Found");
            }
        }
    }
}
