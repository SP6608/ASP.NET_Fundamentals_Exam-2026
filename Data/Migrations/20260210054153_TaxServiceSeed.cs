using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppTaxi2026.Data.Migrations
{
    /// <inheritdoc />
    public partial class TaxServiceSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "TaxServices",
                columns: new[] { "Id", "CarId", "DownTime", "HireDateTime", "TraveledKm" },
                values: new object[,]
                {
                    { 1, 1, 5, new DateTime(2023, 5, 1, 8, 15, 0, 0, DateTimeKind.Unspecified), 6.4000000000000004 },
                    { 2, 2, 12, new DateTime(2023, 5, 1, 9, 5, 0, 0, DateTimeKind.Unspecified), 12.199999999999999 },
                    { 3, 3, 3, new DateTime(2023, 5, 1, 10, 40, 0, 0, DateTimeKind.Unspecified), 4.7999999999999998 },
                    { 4, 4, 15, new DateTime(2023, 5, 1, 12, 10, 0, 0, DateTimeKind.Unspecified), 18.600000000000001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "TaxServices",
                keyColumn: "Id",
                keyValue: 4);

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
        }
    }
}
