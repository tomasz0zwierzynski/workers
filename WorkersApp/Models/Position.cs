using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkersApp.Models
{
    public class Position
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Identyfikator Stanowiska")]
        public int PositionID { get; set; }

        [Display(Name = "Nazwa stanowiska")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Stawka podstawowa")]
        public int Amount { get; set; }

        public ICollection<Salary> Salaries { get; set; }
    }
}
