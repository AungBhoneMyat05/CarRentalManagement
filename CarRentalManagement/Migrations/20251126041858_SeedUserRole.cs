using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "cc21607b-1ffe-45de-bdf5-0e24a799f175", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAC9vE3hbT4I7X9pi4qnOm+VDue46N/pFgj+2jMsIOuf23cAXheCiV+okXG4HZFxcA==", null, false, "f9e2aae1-9ea2-48c8-a1c3-f6d5c7a73598", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8469), new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8482), new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8694), new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8696), new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8629), new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8631), new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8633), new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8634), new DateTime(2025, 11, 26, 12, 18, 57, 623, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3002), new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3021), new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3460), new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3463), new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3337), new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3341), new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3344), new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3347), new DateTime(2025, 11, 26, 11, 47, 25, 143, DateTimeKind.Local).AddTicks(3348) });
        }
    }
}
