using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasstut
{
    public class FullTimeemp:BaseEmployee
    {
    
        public int AnnualSalary { get; set; }

       
        public int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}
