using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cwiczenia_8_APBD_INT.Migrations
{
    public partial class migraton3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "JanKowalski@doktor.com", "Jan", "Kowalski" });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "CezaryPazura@doktor.com", "Cezary", "Pazura" });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 3,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "MichalAniol@doktor.com", "Aniol" });

            migrationBuilder.UpdateData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Type" },
                values: new object[] { "Przeciwbólowy, 120mg 2 razy dziennie", "Ibuprofen", "Przeciwzapalny" });

            migrationBuilder.UpdateData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Type" },
                values: new object[] { "Raz na dzień", "Morfina", "Przeciwbólowy" });

            migrationBuilder.UpdateData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Type" },
                values: new object[] { "Z grzyba", "Penicylyna", "Antybiotyk" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                columns: new[] { "BirthDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(1999, 1, 22, 18, 48, 59, 390, DateTimeKind.Local).AddTicks(7450), "Karol", "Sobotka" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                columns: new[] { "BirthDate", "FirstName" },
                values: new object[] { new DateTime(1973, 1, 22, 18, 48, 59, 393, DateTimeKind.Local).AddTicks(6906), "Andrzej" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                columns: new[] { "BirthDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(1969, 1, 22, 18, 48, 59, 393, DateTimeKind.Local).AddTicks(6938), "Jan", "Nowak" });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 18, 48, 59, 405, DateTimeKind.Local).AddTicks(8704), new DateTime(2023, 3, 23, 18, 48, 59, 405, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate", "IdDoctor" },
                values: new object[] { new DateTime(2023, 1, 22, 18, 48, 59, 405, DateTimeKind.Local).AddTicks(9858), new DateTime(2023, 3, 23, 18, 48, 59, 405, DateTimeKind.Local).AddTicks(9869), 2 });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { new DateTime(2023, 1, 22, 18, 48, 59, 405, DateTimeKind.Local).AddTicks(9873), new DateTime(2023, 3, 23, 18, 48, 59, 405, DateTimeKind.Local).AddTicks(9875), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Details", "Dose" },
                values: new object[] { "2 pigułki, rano i na wieczór", 100 });

            migrationBuilder.UpdateData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "Details", "Dose" },
                values: new object[] { "2 pigułki, rano i na wieczór", 100 });

            migrationBuilder.UpdateData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Details", "Dose" },
                values: new object[] { "2 pigułki, rano i na wieczór", 100 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "SampleDoctor@gmail.com", "Sample", "Doctor" });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "JakubBiologist@gmail.com", "Jakub", "Biologist" });

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 3,
                columns: new[] { "Email", "LastName" },
                values: new object[] { "MichalPediatrician@gmail.com", "Pediatrician" });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 4, "SergioPsychiatrist@gmail.com", "Sergio", "Psychiatrist" },
                    { 6, "AzucarDiabetes@gmail.com", "Azucar", "Diabetes" },
                    { 5, "PabloAnesthesiologist@gmail.com", "Pablo", "Anesthesiologist" }
                });

            migrationBuilder.UpdateData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Type" },
                values: new object[] { "Painkiller, 200mg 3 times a day.", "Ibuprofène", "Anti inflamatory pills" });

            migrationBuilder.UpdateData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Type" },
                values: new object[] { "From 10 to 1000 times a day.", "Happyness", "Anti sadness pills" });

            migrationBuilder.UpdateData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Type" },
                values: new object[] { "CAN HARM YOUR HEALTH.", "Sadness", "Anti happyness pills" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                columns: new[] { "BirthDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(1998, 1, 22, 17, 55, 48, 994, DateTimeKind.Local).AddTicks(6037), "Jakub", "Nowak" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                columns: new[] { "BirthDate", "FirstName" },
                values: new object[] { new DateTime(2002, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7942), "Michal" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                columns: new[] { "BirthDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(1996, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7974), "Patient", "Patientowich" });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 4, new DateTime(2001, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7980), "Sergio", "Kotowich" },
                    { 5, new DateTime(1973, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7983), "Ala", "Peronska" },
                    { 8, new DateTime(1956, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7995), "Jas", "Profase" },
                    { 7, new DateTime(1969, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7992), "Natiel", "Patient" },
                    { 6, new DateTime(1994, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7989), "Kot", "Zygmund" }
                });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 55, 49, 8, DateTimeKind.Local).AddTicks(9551), new DateTime(2023, 4, 22, 17, 55, 49, 8, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate", "IdDoctor" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(875), new DateTime(2023, 4, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(887), 1 });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(890), new DateTime(2023, 4, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(893), 2, 1 });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 1, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(901), new DateTime(2023, 4, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(903), 3, 2 },
                    { 4, new DateTime(2023, 1, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(896), new DateTime(2023, 4, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(898), 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Details", "Dose" },
                values: new object[] { "2 pills in am and pm", 200 });

            migrationBuilder.UpdateData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "Details", "Dose" },
                values: new object[] { "2 pills in am and pm", 250 });

            migrationBuilder.UpdateData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Details", "Dose" },
                values: new object[] { "2 pills in am and pm", 250 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 3, 3, "2 pills in am and pm", 250 });
        }
    }
}
