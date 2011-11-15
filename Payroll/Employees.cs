using System;
using System.Collections.Generic;
using System.Linq;

namespace Payroll
{
    public class Employees
    {
        private List<Employee> employees = new List<Employee>
                                               {
                                                   new Employee { Id = 1, SubsidiaryId = 999, TerminationDate = new DateTime(2010, 10, 1), AccountNumber = 11, AccountType = 100, BankNumber = 7}, 
                                                   new Employee { Id = 2, SubsidiaryId = 3, TerminationDate = new DateTime(2010, 10, 1) , AccountNumber = 12, AccountType = 200, BankNumber = 8}, 
                                                   new Employee { Id = 3, SubsidiaryId = 999, AccountNumber = 13, AccountType = 300, BankNumber = 9}
                                               };
        public Employee GetBy(int id, bool isActive)
        {
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
    }
}