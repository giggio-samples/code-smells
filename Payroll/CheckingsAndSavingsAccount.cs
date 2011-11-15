using System;

namespace Payroll
{
    //account type 300
    public class CheckingsAndSavingsAccount : Account
    {
        private readonly int bankNumber;
        private readonly int accountNumber;

        public CheckingsAndSavingsAccount(int bankNumber)
        {
            this.bankNumber = bankNumber;
        }

        public CheckingsAndSavingsAccount(int bankNumber, int accountNumber)
        {
            this.bankNumber = bankNumber;
            this.accountNumber = accountNumber;
        }

        public override void Credit(decimal amount)
        {
            Console.WriteLine("Credit made on account {0} from bank number {1}, in the amount of {2}, from checkings and savings account", accountNumber, bankNumber, amount);
        }
    }
}