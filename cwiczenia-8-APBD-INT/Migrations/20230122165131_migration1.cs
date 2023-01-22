﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cwiczenia_8_APBD_INT.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    IdDoctor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Doctor_PK", x => x.IdDoctor);
                });

            migrationBuilder.CreateTable(
                name: "Medicament",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("IdMedicament_PK", x => x.IdMedicament);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    IdPatient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("IdPatient_PK", x => x.IdPatient);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    IdPrescription = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPatient = table.Column<int>(type: "int", nullable: false),
                    IdDoctor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("IdPrescription_PK", x => x.IdPrescription);
                    table.ForeignKey(
                        name: "Doctor_Prescription_FK",
                        column: x => x.IdDoctor,
                        principalTable: "Doctor",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Patient_Prescription_FK",
                        column: x => x.IdPatient,
                        principalTable: "Patient",
                        principalColumn: "IdPatient",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescription_Medicament",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(type: "int", nullable: false),
                    IdPrescription = table.Column<int>(type: "int", nullable: false),
                    Dose = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrescriptionMedicamend_PK", x => new { x.IdMedicament, x.IdPrescription });
                    table.ForeignKey(
                        name: "Medicament_Prescription_FK",
                        column: x => x.IdMedicament,
                        principalTable: "Medicament",
                        principalColumn: "IdMedicament",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Prescription_Medicament_FK",
                        column: x => x.IdPrescription,
                        principalTable: "Prescription",
                        principalColumn: "IdPrescription",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "SampleDoctor@gmail.com", "Sample", "Doctor" },
                    { 2, "JakubBiologist@gmail.com", "Jakub", "Biologist" },
                    { 3, "MichalPediatrician@gmail.com", "Michal", "Pediatrician" },
                    { 4, "SergioPsychiatrist@gmail.com", "Sergio", "Psychiatrist" },
                    { 5, "PabloAnesthesiologist@gmail.com", "Pablo", "Anesthesiologist" },
                    { 6, "AzucarDiabetes@gmail.com", "Azucar", "Diabetes" }
                });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 2, "From 10 to 1000 times a day.", "Happyness", "Anti sadness pills" },
                    { 3, "CAN HARM YOUR HEALTH.", "Sadness", "Anti happyness pills" },
                    { 1, "Painkiller, 200mg 3 times a day.", "Ibuprofène", "Anti inflamatory pills" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 7, new DateTime(1969, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1822), "Natiel", "Patient" },
                    { 1, new DateTime(1998, 1, 22, 17, 51, 30, 798, DateTimeKind.Local).AddTicks(7304), "Jakub", "Nowak" },
                    { 2, new DateTime(2002, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1764), "Michal", "Kowalski" },
                    { 3, new DateTime(1996, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1802), "Patient", "Patientowich" },
                    { 4, new DateTime(2001, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1808), "Sergio", "Kotowich" },
                    { 5, new DateTime(1973, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1811), "Ala", "Peronska" },
                    { 6, new DateTime(1994, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1818), "Kot", "Zygmund" },
                    { 8, new DateTime(1956, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1825), "Jas", "Profase" }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(3156), new DateTime(2023, 4, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(3485), 1, 1 },
                    { 3, new DateTime(2023, 1, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4259), new DateTime(2023, 4, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4262), 2, 1 },
                    { 4, new DateTime(2023, 1, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 4, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4267), 3, 1 },
                    { 2, new DateTime(2023, 1, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4245), new DateTime(2023, 4, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4256), 1, 2 },
                    { 5, new DateTime(2023, 1, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 4, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4272), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "2 pills in am and pm", 200 },
                    { 2, 1, "2 pills in am and pm", 250 },
                    { 3, 3, "2 pills in am and pm", 250 },
                    { 2, 2, "2 pills in am and pm", 250 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Email",
                table: "Doctor",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdDoctor",
                table: "Prescription",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdPatient",
                table: "Prescription",
                column: "IdPatient");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Medicament_IdPrescription",
                table: "Prescription_Medicament",
                column: "IdPrescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescription_Medicament");

            migrationBuilder.DropTable(
                name: "Medicament");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
