using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkersApp.Models
{
    public class Worker
    {
        [Display(Name = "Identyfikator")]
        public int ID { get; set; }

        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Display(Name = "Data urodzin")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Adres Email")]
        public string Email { get; set; }

        public ICollection<Salary> Salaries { get; set; }
    }
}
