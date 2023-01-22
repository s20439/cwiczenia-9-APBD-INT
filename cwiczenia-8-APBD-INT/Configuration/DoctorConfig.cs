using cwiczenia_8_APBD_INT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Numerics;

namespace cwiczenia_8_APBD_INT.Configuration
{
    public class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(e => e.IdDoctor).HasName("Doctor_PK");
            builder.Property(e => e.IdDoctor).UseIdentityColumn();

            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();

            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
            builder.HasIndex(e => e.Email).IsUnique();

            // adding data
            var doctors = new List<Doctor>();

            doctors.Add(new Doctor
            {
                IdDoctor = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                Email = "JanKowalski@doktor.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 2,
                FirstName = "Cezary",
                LastName = "Pazura",
                Email = "CezaryPazura@doktor.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 3,
                FirstName = "Michal",
                LastName = "Aniol",
                Email = "MichalAniol@doktor.com"
            });

            builder.HasData(doctors);
        }
    }
}