using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using cwiczenia_8_APBD_INT.Models;

namespace cwiczenia_8_APBD_INT.Configuration
{
    public class PatientConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(e => e.IdPatient).HasName("IdPatient_PK");
            builder.Property(e => e.IdPatient).UseIdentityColumn();

            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.BirthDate).IsRequired();

            // adding data

            var patients = new List<Patient>();

            patients.Add(new Patient
            {
                IdPatient = 1,
                FirstName = "Karol",
                LastName = "Sobotka",
                BirthDate = DateTime.Now.AddYears(-24)
            });

            patients.Add(new Patient
            {
                IdPatient = 2,
                FirstName = "Andrzej",
                LastName = "Kowalski",
                BirthDate = DateTime.Now.AddYears(-50)
            });

            patients.Add(new Patient
            {
                IdPatient = 3,
                FirstName = "Jan",
                LastName = "Nowak",
                BirthDate = DateTime.Now.AddYears(-54)
            });

            

            builder.HasData(patients);
        }
    }
}