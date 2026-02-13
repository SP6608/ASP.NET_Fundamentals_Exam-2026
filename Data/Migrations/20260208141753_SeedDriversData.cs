using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppTaxi2026.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDriversData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01f1fd40-d6bf-42a2-8bc6-ed57aa49922c", "AQAAAAIAAYagAAAAEKGINembgZZYz8qQ3KV9fg5qp4s35gu9o8KIyZH5gTguZ0xh9q60uDflwrLwnMJZGg==", "cd275d76-961c-4f2c-b375-358b8aae6737" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebeaf1c8-daf4-4c36-9a8b-479f411566f3", "AQAAAAIAAYagAAAAEIqSB7R3tENawkOvxcxm+me/jiHlbJODlgEyaxuK1UCqrzrO7jn3wPxX00wznGQ2Qw==", "fbe0e59d-aeb5-47f5-8015-196cff1cf681" });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Address", "FirstName", "GSM", "IDCard", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, "Sofia, Bulgaria", "Ivan", "+359888123456", "BG123456", "Petrov", "driver-user-1" },
                    { 2, "Plovdiv, Bulgaria", "Georgi", "+359888654321", "BG654321", "Ivanov", "driver-user-2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b6735ba-a5f3-445d-bf74-54ae4f93e8b9", "AQAAAAIAAYagAAAAEILA2XaNwPpGnyIsyXgbGZVj4qcFzINnjfwiNM2KKNAOBPycaiz+1J8veZph75ASrQ==", "8eada9ce-fa7f-4c6e-9e37-062f3f9e0db0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bb7a4e3-e76d-4793-a069-919d806da1d0", "AQAAAAIAAYagAAAAEGpN7y/kOfgOOt0D7haPqlSMuYk3x08jrPAq3/piYK3V8DI8o+J4Ikbo6ccYF5OxWw==", "25848901-8886-4cb8-bc78-56eb92d205f2" });
        }
    }
}
