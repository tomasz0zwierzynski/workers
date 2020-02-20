using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkersApp.Models
{
    public class SalaryViewModel
    {
        public int SalaryID { get; set; }
        public int Bonus { get; set; }
        public int PositionAmount { get; set; }
        public string PositionName { get; set; }
    }
}
