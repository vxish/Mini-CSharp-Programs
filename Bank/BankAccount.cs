using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount
    {

        public double Overdarft { get; set; }

        public String AccountNo { get; }

        public double Balance { get; private set; }

        public double AvailableBalance
        {
            get { return Balance + Overdarft; }

        }

        public BankAccount(string accountNumber)
        {
            AccountNo = accountNumber;
            Balance = 0;
            Overdarft = 0;

        }

        public BankAccount(string accountNumber, double balance)
        {
            AccountNo = accountNumber;
            Balance = balance;
            Overdarft = 0;

        }
   

        public void Deposit(double amount)
        {
        Balance = Balance + amount;
        }

        public bool Withdraw(double amount)
        {
        bool success = false;
        if (amount <= AvailableBalance)
            {
                Balance = Balance - amount;
                success = true;
            }
            return success;
        }

        public string ToString()
        {
            return String.Format("Account number {0} has a balance of {1:C} and an Overdarft Facility of {2:C}",
                AccountNo,
                Balance,
                Overdarft);
        }
}



}