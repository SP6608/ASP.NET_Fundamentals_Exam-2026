using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppTaxi2026.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDbForUpr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaxServices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaxServices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaxServices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73c486a8-8b57-446e-b35a-7b75d2441aba", "AQAAAAIAAYagAAAAEJaHKgYwKLHtf+d+XsmXrJOpeWtPuyMrnaQSyTxwP2KzNVz6phRgUWGCaNc44MUVzQ==", "0b47cd68-3843-4734-be69-549768c111cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "260f3de9-5ef7-4e39-8978-f0ec73fafaf2", "AQAAAAIAAYagAAAAEJbZycG5JycFyM9JLElqZC4NIv8KfAiNqG9lcABNabiszcbOHwe7TrqO0WRpaBhoKg==", "2e3f1290-a75c-43d1-abc8-0b08e679f52b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "830671e5-e64f-4753-a1b4-3b655e73f404", "AQAAAAIAAYagAAAAEGsrQ5/V1xKKb8qQEhJE9gqDMeU99g+TB290MY0SzyFcBxJ6xlIh3wZhSKjwCmHEOw==", "ef8d01fa-ce7a-4d6a-84e2-a6f63c38b98e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a865b516-f07c-434e-bbc6-cd1955fceb67", "AQAAAAIAAYagAAAAEHx5GpCKlB+FkV+ehF3WZVUAUnzkc10Tu51866Egpk8gLp4OHkBr2+KKnYunPdrpjg==", "9bc118f0-7e77-40c0-a780-9302774f044f" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "DriverId", "InitialFee", "Places", "PricePerKm", "PricePerMinute", "RegNumber", "Year" },
                values: new object[,]
                {
                    { 1, "Toyota Corolla", 1, 2.5, 4, 1.2, 0.29999999999999999, "CB1234AB", 2018 },
                    { 2, "Skoda Octavia", 1, 3.0, 4, 1.3999999999999999, 0.34999999999999998, "CB5678CD", 2020 },
                    { 3, "Volkswagen Passat", 2, 2.7999999999999998, 4, 1.25, 0.32000000000000001, "PB1111EF", 2017 },
                    { 4, "Dacia Logan", 2, 2.0, 4, 1.1000000000000001, 0.28000000000000003, "PB2222GH", 2019 }
                });

            migrationBuilder.InsertData(
                table: "TaxServices",
                columns: new[] { "Id", "CarId", "DownTime", "HireDateTime", "TraveledKm" },
                values: new object[,]
                {
                    { 1, 1, 5, new DateTime(2023, 5, 1, 8, 15, 0, 0, DateTimeKind.Unspecified), 6.4000000000000004 },
                    { 2, 2, 12, new DateTime(2023, 5, 1, 9, 5, 0, 0, DateTimeKind.Unspecified), 12.199999999999999 },
                    { 3, 3, 3, new DateTime(2023, 5, 1, 10, 40, 0, 0, DateTimeKind.Unspecified), 4.7999999999999998 }
                });
        }
    }
}
