using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountAndDictionary
{
    public class Account
    {
        public decimal Saldo { get; private set; }

        public string AccountNumber { get; private set; }

        public Account(string accountNumber, decimal saldo)
        {
            AccountNumber = accountNumber;
            Saldo = saldo;
        }


    }
}
