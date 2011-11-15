using System;
using System.Collections.Generic;
using System.Linq;

namespace Payroll
{
    public class Employees
    {
        public Employee GetBy(int id)
        {
            return employees.SingleOrDefault(e => e.Id == id);
        }

        public Employee GetBy(int id, bool isActive)
        {
            //user is active if termination date is null and subsidiary id is 999
            if (isActive)
            {
                return (from e in employees
                        where e.Id == id && e.TerminationDate == null && e.SubsidiaryId == 999
                        select e).SingleOrDefault();
            }
            return (from e in employees
                    where e.Id == id && e.TerminationDate != null || e.SubsidiaryId != 999
                    select e).SingleOrDefault();
        }

        public Employee GetBy(int bankNumber, int accountNumber)
        {
            return (from e in employees
                    where e.BankNumber == bankNumber && e.AccountNumber == accountNumber
                    select e).SingleOrDefault();
        }
        //simulando banco de dados:
        private List<Employee> employees = new List<Employee>
                                               {
                                                   new Employee { Id = 1, SubsidiaryId = 999, TerminationDate = new DateTime(2010, 10, 1), AccountNumber = 11, AccountType = 100, BankNumber = 7}, 
                                                   new Employee { Id = 2, SubsidiaryId = 3, TerminationDate = new DateTime(2010, 10, 1) , AccountNumber = 12, AccountType = 200, BankNumber = 8}, 
                                                   new Employee { Id = 3, SubsidiaryId = 999, AccountNumber = 13, AccountType = 300, BankNumber = 9},
                                                   new Employee { Id = 4, SubsidiaryId = 999, AccountNumber = 14, AccountType = 200, BankNumber = 10},
                                                   new Employee { Id = 5, SubsidiaryId = 999, AccountNumber = 15, AccountType = 100, BankNumber = 11}
                                               };
    }
}