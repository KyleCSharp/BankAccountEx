using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationEx1
{
    public class BankAccount
    {
        public BankAccount()
        {
        }
        private double Balance = 0;

       

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public double GetBalance()
        {
            return Balance;
        }






    }
}
