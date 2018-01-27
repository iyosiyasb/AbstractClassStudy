using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasstut
{
    public class Contractemp:BaseEmployee
    {
        
        public int HourlyPay{ get; set; }
        public int TotalHours { get; set; }

       
        public int GetMonthlySalary()
        {
            return this.HourlyPay* this.TotalHours ;
        }
    }
}
