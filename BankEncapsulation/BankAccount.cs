﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double balance;

        public void Deposit (double amount)
        {
            balance += amount;
        }
        public double GetBalance()
        {
            return balance;
        }

    }
}
