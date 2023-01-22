using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cwiczenia_8_APBD_INT.Migrations
{
    public partial class userAuthentication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    RerfreshTokenExpiration = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("User_PK", x => x.IdUser);
                });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1999, 1, 22, 19, 10, 51, 653, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(1973, 1, 22, 19, 10, 51, 658, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1969, 1, 22, 19, 10, 51, 658, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 19, 10, 51, 670, DateTimeKind.Local).AddTicks(1728), new DateTime(2023, 3, 23, 19, 10, 51, 670, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 19, 10, 51, 670, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 3, 23, 19, 10, 51, 670, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 19, 10, 51, 670, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 3, 23, 19, 10, 51, 670, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.CreateIndex(
                name: "IX_User_Login",
                table: "User",
                column: "Login",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1999, 1, 22, 18, 48, 59, 390, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(1973, 1, 22, 18, 48, 59, 393, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1969, 1, 22, 18, 48, 59, 393, DateTimeKind.Local).AddTicks(6938));

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
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 18, 48, 59, 405, DateTimeKind.Local).AddTicks(9858), new DateTime(2023, 3, 23, 18, 48, 59, 405, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 1, 22, 18, 48, 59, 405, DateTimeKind.Local).AddTicks(9873), new DateTime(2023, 3, 23, 18, 48, 59, 405, DateTimeKind.Local).AddTicks(9875) });
        }
    }
}
