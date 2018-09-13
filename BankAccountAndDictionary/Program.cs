using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();

            var a1 = new Account("11111", 1000.00m);
            var a2 = new Account("22222", 2000.00m);
            var a3 = new Account("33333", 3000.00m);
            var a4 = new Account("44444", 4000.00m);

            bank.AddAccount(a1);
            bank.AddAccount(a2);
            bank.AddAccount(a3);
            bank.AddAccount(a4);

            Console.WriteLine($"Totalsaldo: {bank.GetTotalSaldo():0.00} kr");

            // Hitta konto med kontonummer X och skriv ut saldo
            Console.WriteLine("Ange kontonummer:");
            string findAccount = Console.ReadLine();

            Console.WriteLine("Saldo:" + bank.Accounts[findAccount].Saldo);

            //for (int i = 0; i < bank.Accounts.Count; i++)
            //{
            //    if (bank.Accounts[i].AccountNumber == findAccount)
            //    {
            //        Console.WriteLine("Saldo:" + bank.Accounts[i].Saldo);
            //    }
            //}


        }
    }
}
