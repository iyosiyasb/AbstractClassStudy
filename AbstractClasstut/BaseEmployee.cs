using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasstut
{
    public class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }
    }
}
