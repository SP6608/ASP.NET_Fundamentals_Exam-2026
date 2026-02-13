using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppTaxi2026.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0edffa7b-4eb4-4f07-b1a1-7bb82cc815b6", "AQAAAAIAAYagAAAAEBUkME5uL3to0kUGS9F36YztOt+cvH9LrEtoN8g6cH+j8fTxVP8Vrp46oYahn6UhPQ==", "2052e42b-0b24-4bfd-a110-6ea90d21a023" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "driver-user-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1175055-425b-44aa-b2b0-9d40744530b2", "AQAAAAIAAYagAAAAEA2uT1Fjhe+1G13r+JYCfBz2Gc3wkrnJ8QvTpSj/QcuqIiGMTskQJ9GmgdIZMmaLnA==", "cf7226ed-902c-4537-8d3e-86364d8059a8" });
        }
    }
}
