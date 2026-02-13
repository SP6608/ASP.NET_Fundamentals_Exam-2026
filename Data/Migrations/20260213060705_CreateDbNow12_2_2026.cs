using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppTaxi2026.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDbNow12_2_2026 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "driver-user-1", 0, "4602aae3-394e-41c0-88aa-3b66ef545d4e", "driver1@taxi.com", true, false, null, "DRIVER1@TAXI.COM", "DRIVER1@TAXI.COM", "AQAAAAIAAYagAAAAEMQYTT/I9tPL2EhO60i4rKkJFtawRVLnkR2yoo98KKPtnIrz/G308Uoc5Jo01oXX6w==", null, false, "a71c3309-2fae-468b-97e8-d8c4e7bcfd06", false, "driver1@taxi.com" },
                    { "driver-user-2", 0, "c83a108b-16a2-4bea-ab74-1443d6f720a4", "driver2@taxi.com", true, false, null, "DRIVER2@TAXI.COM", "DRIVER2@TAXI.COM", "AQAAAAIAAYagAAAAEMkzRhs+ljn4yFeqp2d9qyJ4XpGt9ak+t8QDWQSTUP2/cVuXsbKWirRnLo7gB8w2cA==", null, false, "049d1be6-367d-4631-8677-7ccf5e5994f7", false, "driver2@taxi.com" }
                });
        }
    }
}
