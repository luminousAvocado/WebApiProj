using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProj.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

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

        // DentistId as a FK to a patient's dentist. We make this nullable 
        // in case primary dentist undetermined at time.
        // EF Core will automatically associate as FK, but can also use 
        // Data Annotations [ForeignKey("DentistFK")] to specify
        public int? DentistId { get; set; }
        public Dentist Dentist { get; set; }
    }
}
