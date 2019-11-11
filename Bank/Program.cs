using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create account with Account number
            BankAccount acc1 = new BankAccount("Acc01");
            Console.WriteLine(acc1.ToString());

            //Create account with Account number and balance
            BankAccount acc2 = new BankAccount("Acc02", 10.00);
            Console.WriteLine(acc2.ToString());

            //acc2.AccountNo = "error";
            Console.WriteLine(acc2.AccountNo);
           // acc2.Balance = 50;
            Console.WriteLine(acc2.Balance);

            Console.WriteLine("Before: " + acc2.Overdarft);
            acc2.Overdarft = 100;
            Console.WriteLine("After: " + acc2.Overdarft);

            //acc2.AvailableBalance = 50;
            Console.WriteLine(acc2.AvailableBalance);

            Console.WriteLine("Before: " + acc1.Balance);
            acc1.Deposit(50);
            Console.WriteLine("After: " + acc1.Balance);


            Console.WriteLine("Before: " + acc1.Balance);
            if (acc1.Withdraw(50))
            {
                Console.WriteLine("£50 withdrawn");
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
            Console.WriteLine("After: " + acc1.Balance);

            Console.WriteLine("Before: " + acc1.Balance);
            if (acc1.Withdraw(0.01))
            {
                Console.WriteLine("£0.01 withdrawn");
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
            Console.WriteLine("After: " + acc1.Balance);


            acc1.Overdarft = 100;
            Console.WriteLine("Overdraft: " + acc1.Overdarft);
            Console.WriteLine("Before: " + acc1.Balance);
            if (acc1.Withdraw(100))
            {
                Console.WriteLine("£100 withdrawn");
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
            Console.WriteLine("After: " + acc1.Balance);


            Console.WriteLine("Before: " + acc1.Balance);
            if (acc1.Withdraw(0.01))
            {
                Console.WriteLine("£0.01 widthdrawn");
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
            Console.WriteLine("After: " + acc1.Balance);

            Console.ReadLine();
        }
    }
}
