using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppTaxi2026.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a4ef236-6e6a-442c-ba90-5fd3a258cac9", "AQAAAAIAAYagAAAAEIN3UQDvwwRR7ZGuvvMT1jAq3Z5efwqT5DD8bXP6aPqrwfdKv0WDZSiih++IcLf/yw==", "3728d276-92a0-4661-8210-3868c43b47c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70ba3d67-8507-489f-9a69-bcf5147dd786", "AQAAAAIAAYagAAAAEKxjc48b+IU8d/JulZbyf87mxx3vI3f8YgQkulEGAxFnS+HurLJqqc5hY65H34V6pA==", "67076de7-e2ca-4c1c-bd9e-562191443ec0" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

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
    }
}
