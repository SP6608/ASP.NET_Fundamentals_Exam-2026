using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppTaxi2026.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataFromRegisteredUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "driver-user-1", 0, "5b6735ba-a5f3-445d-bf74-54ae4f93e8b9", "driver1@taxi.com", true, false, null, "DRIVER1@TAXI.COM", "DRIVER1@TAXI.COM", "AQAAAAIAAYagAAAAEILA2XaNwPpGnyIsyXgbGZVj4qcFzINnjfwiNM2KKNAOBPycaiz+1J8veZph75ASrQ==", null, false, "8eada9ce-fa7f-4c6e-9e37-062f3f9e0db0", false, "driver1@taxi.com" },
                    { "driver-user-2", 0, "1bb7a4e3-e76d-4793-a069-919d806da1d0", "driver2@taxi.com", true, false, null, "DRIVER2@TAXI.COM", "DRIVER2@TAXI.COM", "AQAAAAIAAYagAAAAEGpN7y/kOfgOOt0D7haPqlSMuYk3x08jrPAq3/piYK3V8DI8o+J4Ikbo6ccYF5OxWw==", null, false, "25848901-8886-4cb8-bc78-56eb92d205f2", false, "driver2@taxi.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-2");
        }
    }
}
