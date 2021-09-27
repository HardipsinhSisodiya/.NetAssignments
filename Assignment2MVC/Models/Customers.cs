using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2MVC.Models
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string CustomerType{ get; set; }
        public List<string> Customersnos { get; set; }
        public Customers()
        {
            Customersnos = new List<string>();
        }
       
    }
}
