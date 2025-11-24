using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(908), new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(918), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(920), new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(920), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(1120), new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(1121), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(1122), new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(1123), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(1064), new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(1065), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(1066), new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(1066), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(1067), new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(1068), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(1069), new DateTime(2025, 11, 24, 15, 43, 39, 899, DateTimeKind.Local).AddTicks(1069), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
