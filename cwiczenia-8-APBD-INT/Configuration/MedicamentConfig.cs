using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using cwiczenia_8_APBD_INT.Models;

namespace cwiczenia_8_APBD_INT.Configuration
{
    public class MedicamentConfig : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(e => e.IdMedicament).HasName("IdMedicament_PK");
            builder.Property(e => e.IdMedicament).UseIdentityColumn();

            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Type).HasMaxLength(100).IsRequired();

            // adding data

            var medicaments = new List<Medicament>();

            medicaments.Add(new Medicament
            {
                IdMedicament = 1,
                Name = "Ibuprofen",
                Description = "Przeciwbólowy, 120mg 2 razy dziennie",
                Type = "Przeciwzapalny"
            });

            medicaments.Add(new Medicament
            {
                IdMedicament = 2,
                Name = "Morfina",
                Description = "Raz na dzień",
                Type = "Przeciwbólowy"
            });

            medicaments.Add(new Medicament
            {
                IdMedicament = 3,
                Name = "Penicylyna",
                Description = "Z grzyba",
                Type = "Antybiotyk"
            });

            builder.HasData(medicaments);
        }
    }
}