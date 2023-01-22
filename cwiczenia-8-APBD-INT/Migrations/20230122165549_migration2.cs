using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cwiczenia_8_APBD_INT.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1998, 1, 22, 17, 55, 48, 994, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2002, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1996, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2001, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1973, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(1994, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(1969, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(1956, 1, 22, 17, 55, 48, 996, DateTimeKind.Local).AddTicks(7995));

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
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(875), new DateTime(2023, 4, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(890), new DateTime(2023, 4, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(896), new DateTime(2023, 4, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(901), new DateTime(2023, 4, 22, 17, 55, 49, 9, DateTimeKind.Local).AddTicks(903) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1998, 1, 22, 17, 51, 30, 798, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2002, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1996, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2001, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1973, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(1994, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(1969, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(1956, 1, 22, 17, 51, 30, 803, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(3156), new DateTime(2023, 4, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4245), new DateTime(2023, 4, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4259), new DateTime(2023, 4, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 4, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 4, 22, 17, 51, 30, 814, DateTimeKind.Local).AddTicks(4272) });
        }
    }
}
