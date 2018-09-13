using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountAndDictionary
{
    public class Bank
    {
        public string Name { get; set; }

        public Dictionary<string, Account> Accounts { get; private set; }

        public Bank()
        {
            Accounts = new Dictionary<string, Account>();
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account.AccountNumber, account);
        }

        public decimal GetTotalSaldo()
        {
            decimal totalSaldo = 0;
            foreach (Account account in this.Accounts.Values)
            {
                totalSaldo += account.Saldo;
            }

            return totalSaldo;
        }
    }
}
