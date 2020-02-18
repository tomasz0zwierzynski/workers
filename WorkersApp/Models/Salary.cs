using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkersApp.Models
{
    public class Salary
    {
        [Display(Name = "Identyfikator")]
        public int SalaryID { get; set; }

        [Display(Name = "Identyfikator Pracownika")]
        public int WorkerID { get; set; }

        [Display(Name = "Identyfikator Stanowiska")]
        public int PositionID { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Premia")]
        public int Bonus { get; set; }

        public Worker Worker { get; set; }
        public Position Position { get; set; }
    }
}
