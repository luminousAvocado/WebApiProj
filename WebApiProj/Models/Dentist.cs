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

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        public bool? Active { get; set; } = true;

        // We use ICollection because we may need to be able add/remove patients.
        // But dont necessarily need to access by index (IList)
        public ICollection<Patient> Patients { get; set; }
    }
}
