using System.Collections.Generic;
using System;

namespace cwiczenia_8_APBD_INT.Models
{
    public class Patient
    {
        public Patient()
        {
            Prescriptions = new HashSet<Prescription>();
        }


        public int IdPatient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }


        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
