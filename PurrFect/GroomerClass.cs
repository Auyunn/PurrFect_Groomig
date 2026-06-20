using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurrFect
{

    public class GroomerClass : Person, GroomerService
    {
        public int GroomerID { get; set; }
        public string Status { get; set; }
        public decimal Salary { get; set; }

        public decimal CalculateAnnualSalary(decimal salary)
        {
            return salary * 12;
        }
    }

}
