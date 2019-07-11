using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProj.Models
{
    public class Dentist
    {
        public int DentistId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        //public IList<Patient> Patients { get; set; }
    }
}
