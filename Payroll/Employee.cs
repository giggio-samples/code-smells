using System;

namespace Payroll
{
    public class Employee
    {
        public int Id { get; set; }

        public DateTime? TerminationDate { get; set; }

        public int SubsidiaryId { get; set; }

        public int BankNumber { get; set; }

        public int AccountType { get; set; }

        public int AccountNumber { get; set; }
    }
}