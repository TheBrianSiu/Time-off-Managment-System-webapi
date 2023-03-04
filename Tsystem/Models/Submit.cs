using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tsystem.Models
{
    public class Submit
    {
        public long id { get; set; }

        public String Firstname { get; set; }
        public String Lastname { get; set; }

        public String begindate{ get; set; }

        public String enddate { get; set; }
        public Double hours { get; set; }
        public Boolean pto { get; set; }
        public Boolean sick { get; set; }     
        public String message { get; set; }
    }

    public class Employee
    {
        public long id { get; set; }

        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public Double pto_hours { get; set; }
        public Double sick_hours { get; set; }
    }
}
