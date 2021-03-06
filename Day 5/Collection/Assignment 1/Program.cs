using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice = -1;
            while (true)
            {
                Console.WriteLine("Enter your choice");

                Console.WriteLine("1.Add new employee");
                Console.WriteLine("2.Search product id");
                Console.WriteLine("3.Delete all product");
                Console.WriteLine("4.Display all product");
                Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        SearchEmployee();
                        break;
                    case 3:
                        DeleteEmployee();
                        break;
                    case 4:
                        DisplayEmployee();
                        break;
                    default:
                        Console.WriteLine("Enter right choice");
                        break;
                }
            }

        }
        private static void AddEmployee()
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
            try
            {
                using (var Connection = new SqlConnection(ConnectionString))
                {
                    Console.WriteLine("Enter ID");
                    int ID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Name");
                    string Name = Console.ReadLine();

                    Console.WriteLine("Enter Price");
                    int Price = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Description");
                    string Description = Console.ReadLine();

                    Console.WriteLine("Enter IsActive");
                    string IsActive = Console.ReadLine();

                    var Query = $"insert into Product values({ID},'{Name}',{Price},'{Description}','{IsActive}')";
                    var Command = new SqlCommand(Query, Connection);
                    Connection.Open();
                    int Rows = Command.ExecuteNonQuery();
                    Console.WriteLine($"{Rows} affected");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception Occured" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred" + ex.Message);
            }


        }
        private static void SearchEmployee()
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
            try
            {
                using (var Connection = new SqlConnection(ConnectionString))
                {
                    Console.WriteLine("Enter ID for search");
                    int ID = Convert.ToInt32(Console.ReadLine());

                    var Query = $"select * from Product where ID={ID}";
                    var Command = new SqlCommand(Query, Connection);
                    Connection.Open();
                    SqlDataReader Rows = Command.ExecuteReader();
                    Rows.Read();

                    int ID1 = Rows.GetInt32(0);
                    String Name = Rows.GetString(1);
                    int Price = Rows.GetInt32(2);
                    string Description = Rows.GetString(3);
                    string IsActive = Rows.GetString(4);
                    Console.WriteLine($"ID={ID1},Name={Name},Price={Price},Description={Description},IsActive={IsActive}");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception Occured" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred" + ex.Message);
            }
        }
        private static void DeleteEmployee()
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
            try
            {
                using (var Connection = new SqlConnection(ConnectionString))
                {
                    Console.WriteLine("Enter ID for delete");
                    int ID = Convert.ToInt32(Console.ReadLine());

                    var Query = $"delete from Product where ID={ID}";
                    var Command = new SqlCommand(Query, Connection);
                    Connection.Open();
                    int Rows = Command.ExecuteNonQuery();
                    if (Rows > 0)
                    {
                        Console.WriteLine($"{Rows} affected");
                    }
                    else
                    {
                        Console.WriteLine("Data not found");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception Occured" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred" + ex.Message);
            }
        }
        private static void DisplayEmployee()
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
            try
            {
                using (var Connection = new SqlConnection(ConnectionString))
                {
                    var Query = "select * from Product";
                    var Command = new SqlCommand(Query, Connection);
                    Connection.Open();
                    SqlDataReader Rows = Command.ExecuteReader();
                    if(Rows.HasRows)
                    {
                        while(Rows.Read())
                        {
                            int ID = Rows.GetInt32(0);
                            String Name = Rows.GetString(1);
                            int Price = Rows.GetInt32(2);
                            string Description = Rows.GetString(3);
                            string IsActive = Rows.GetString(4);
                            Console.WriteLine($"ID={ID},Name={Name},Price={Price},Description={Description},IsActive={IsActive}");
                        }
                    }
                   
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception Occured" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred" + ex.Message);
            }
        }
    }
}
