using System;

namespace Payroll
{
    //account type 100
    public class CheckingsAccount : Account
    {
        private readonly int bankNumber;
        private readonly int accountNumber;

        public CheckingsAccount(int bankNumber)
        {
            this.bankNumber = bankNumber;
        }

        public CheckingsAccount(int bankNumber, int accountNumber)
        {
            this.bankNumber = bankNumber;
            this.accountNumber = accountNumber;
        }

        public override void Credit(decimal amount)
        {
            Console.WriteLine("Credit made on account {0} from bank number {1}, in the amount of {2}, from checkings account", accountNumber, bankNumber, amount);
        }
    }
}