using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Details
    {
        //private string CoustomerName;
        public string CustomerName { get; set; }
        public string OrderDate { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }

        public int TotalAmount { get; set; }

        public int x,y;
        public void CalculateOrderAmount( int a,int b)
        {
            x = a;
            y = b;
            TotalAmount= x * y;
        }
        public void PrintOrderDetails(string Customername,DateTime OrderDate,string ProductName,int ProductPrice,int Quantity)
        {
            Console.WriteLine("Your order details.....");
            Console.WriteLine("Customer: " +Customername);
            Console.WriteLine("OrderDate: " +OrderDate);
            Console.WriteLine("ProductName: " +ProductName);
            Console.WriteLine("ProductPrice: " +ProductPrice);
            Console.WriteLine("Quantity: " +Quantity);
            Console.WriteLine("TotalAmount: " +TotalAmount);
            Console.WriteLine("Thank you for shopping...!!");

        }
    }
    class Order
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to order management system.......");
            Console.WriteLine("Enter Your Name");
            string CustomerName = Console.ReadLine();

            //Console.WriteLine("Enter Order Date......");
            //Console.WriteLine("Enter date");
            DateTime OrderDate = DateTime.Today;// Convert.ToDateTime( Console.ReadLine());

            
            Console.WriteLine("Enter Productname");
            string ProductName = Console.ReadLine();

            Console.WriteLine("Enter Product Price");
            int ProductPrice =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Quantity");
            int Quantity = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Your Total Amount");
            //int TotalAmount =Convert.ToInt32( Console.ReadLine());

            Details Obj = new Details();
            Obj.CalculateOrderAmount(ProductPrice, Quantity);
            Obj.PrintOrderDetails(CustomerName,OrderDate, ProductName, ProductPrice, Quantity);
            Console.ReadKey();
        }
    }
}
