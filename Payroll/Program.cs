using System;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter employee id:");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter amount to pay:");
            var amount = Convert.ToDecimal(Console.ReadLine());

            var employee = new Employees().GetBy(id, true);
            var account = new Bank(employee.BankNumber).GetAccountFor(employee.AccountType, employee.AccountNumber);

            account.Credit(amount);

            Console.WriteLine("Finished. Press any key to terminate.");
            Console.ReadKey();
        }
    }
}
