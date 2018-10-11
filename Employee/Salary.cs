using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Salary : IAccountantSalary, IEmployeeSalary, ISizeSalary
    {
        public int SalaryAmount { get; private set; }
        public int SizeSalary { get; set; }

        public void Pay(int amount)
        {
            SalaryAmount += amount;
        }
    }
}
