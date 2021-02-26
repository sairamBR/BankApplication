using System;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
          var account = new BankAccount("ShamiliPriya", 10000);
          Console.WriteLine("Wellcome SANA SMALL FINANCE BANK PVT.Ltd");
          Console.WriteLine($"Account No: {account.Number}");
          Console.WriteLine($"Owner of the Account: {account.Owner}");
          Console.WriteLine($"Account Balance:  {account.Balance}");

          Console.WriteLine("-------------------------------------------------------------------------");
          account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
          Console.WriteLine("Balance after withdrawal on "+ DateTime.Now + "    "+ account.Balance);
          account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
          Console.WriteLine("Balance After Deposit on " + DateTime.Now + "       "+ account.Balance);
          Console.WriteLine("-------------------------------------------------------------------------");
          Console.WriteLine("Current Balance                                    " +account.Balance);

          Console.WriteLine(account.GetAccountHistory());
        }
    }
}
