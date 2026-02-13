using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppTaxi2026.Data.Migrations
{
    /// <inheritdoc />
    public partial class bbb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4602aae3-394e-41c0-88aa-3b66ef545d4e", "AQAAAAIAAYagAAAAEMQYTT/I9tPL2EhO60i4rKkJFtawRVLnkR2yoo98KKPtnIrz/G308Uoc5Jo01oXX6w==", "a71c3309-2fae-468b-97e8-d8c4e7bcfd06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c83a108b-16a2-4bea-ab74-1443d6f720a4", "AQAAAAIAAYagAAAAEMkzRhs+ljn4yFeqp2d9qyJ4XpGt9ak+t8QDWQSTUP2/cVuXsbKWirRnLo7gB8w2cA==", "049d1be6-367d-4631-8677-7ccf5e5994f7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e49122a5-9414-4757-a031-98739cc4720d", "AQAAAAIAAYagAAAAEEHcsg3arlmFv7tMxO31iejJfRCSybzvPAE0tZNx/ugH260yK8QMbg7BQfIc/faFjQ==", "57b0f741-d407-4d4a-be24-84ce7c499ff5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd583a8d-1f34-406e-855f-74cda298812a", "AQAAAAIAAYagAAAAELk4wGgjyThM9DkYMdeuc+i+64RcpUmCYJ4vrwAEWLDHyJwLl71usofAbox/Abs+vQ==", "49ed8b1a-1770-45ba-a6a6-5fde426fda28" });
        }
    }
}
