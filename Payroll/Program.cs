using System;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            //gets user input:
            Console.WriteLine("Please enter employee id:");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter amount to pay:");
            var amount = Convert.ToDecimal(Console.ReadLine());

            //get employee:
            var employee = new Employees().GetBy(id, true);
            //credit employee
            new Bank(employee.BankNumber).GetAccountFor(employee.AccountType, employee.AccountNumber).Credit(amount);

            //prints ending
            Console.WriteLine("Finished. Press any key to terminate.");
            Console.ReadKey();
        }
    }
}
