using System;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
          var account = new BankAccount("ShamiliPriya");
          Console.WriteLine("Wellcome SANA SMALL FINANCE BANK PVT.Ltd");
          Console.WriteLine($"Account No: {account.Number}");
          Console.WriteLine($"Owner of the Account: {account.Owner}");
          Console.WriteLine($"Account Balance:  {account.Balance}");
        }
    }
}
