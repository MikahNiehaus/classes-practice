using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    public class BankAccount
    {

        public int Balance;

        public BankAccount(int balance)
        {
            Balance = balance;
        }

        public int AcountBalance() => Balance;
    }
}
