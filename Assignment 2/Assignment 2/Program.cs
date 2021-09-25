using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    abstract class Account
    {

        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public int Balance { get; set; }
        public abstract void WithdrawAmount(int WithdrawRef);
        public void DepositAmount()
        {
        }

    }
    class SavingAccount:Account
    {
      // private int Balance = 1000;
        public SavingAccount()
        {
            Balance = 2000;
        }
        public void Check(int Amount)
        {
           if (Balance - Amount < 500)
           {
                Console.WriteLine("You cant withdraw");
                Console.WriteLine("You balance is:" + Balance);
            }
           else
           {
               WithdrawAmount(Amount);
           }
        }
        public override void WithdrawAmount(int WithdrawRef)
        {
            int Withdraw = WithdrawRef;
            Console.WriteLine("Amount before withdrawal is: " + Balance);
            Balance -= Withdraw;
            Console.WriteLine("Amount after withdrawal is: " + Balance);
        }
        public void DepositAmount(int DepositRef)
        {
            Console.WriteLine("Amount before deposit is: " + Balance);
            int add = DepositRef;
            Balance += DepositRef;
            Console.WriteLine("Amount after deposit is: " + Balance);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Number");
            int ProductName =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Customer name");
            string CustomerName = Console.ReadLine();

            Console.WriteLine("Enter amount to perform operation");
            int Amount =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter your choice what you want to do");
            Console.WriteLine("1.Withdraw");
            Console.WriteLine("2.Deposit");
            int Choice = Convert.ToInt32(Console.ReadLine());
            SavingAccount Obj = new SavingAccount();
            switch(Choice)
            {
                case 1:
                    Obj.Check(Amount);
                    break;

                case 2:
                    Obj.DepositAmount(Amount);
                    break;

                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
