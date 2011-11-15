using System;

namespace Payroll
{
    public class Bank
    {
        private readonly int bankNumber;

        public Bank(int bankNumber)
        {
            this.bankNumber = bankNumber;
        }

        public Account GetAccountFor(int accountType, int accountNumber)
        {
            switch (accountType)
            {
                case 100:
                    return new CheckingsAccount(bankNumber, accountNumber);
                case 200:
                    return new SavingsAccount(bankNumber, accountNumber);
                case 300:
                    return new CheckingsAndSavingsAccount(bankNumber, accountNumber);
            }
            //throws if account type is invalid
            throw new ArgumentException("account type not found", "accountType");
        }

    }
}