using System;

namespace Payroll
{
    public class SavingsAccount : Account
    {
        private readonly int bankNumber;
        private readonly int accountNumber;

        public SavingsAccount(int bankNumber)
        {
            this.bankNumber = bankNumber;
        }

        public SavingsAccount(int bankNumber, int accountNumber)
        {
            this.bankNumber = bankNumber;
            this.accountNumber = accountNumber;
        }

        public override void Credit(decimal amount)
        {
            Console.WriteLine("Credit made on account {0} from bank number {1}, in the amount of {2}, from savings account", accountNumber, bankNumber, amount);
        }
    }
}