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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d926daf5-8801-4303-b2ce-ea0c5bc6ffd7", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEL/RjQc9l8GkQrsbq9aY7qmdCNBrVx3obGXepwWlc0ygBRyB8u+hitb/HUnEkT2xcQ==", null, false, "93b24ec6-a049-48a8-9d7e-e41996595f20", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9463), new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9481), new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9753), new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9757), new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9878), new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9882), new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9885), new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9887), new DateTime(2024, 11, 20, 12, 18, 25, 206, DateTimeKind.Local).AddTicks(9888) });

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

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(6877), new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(6897), new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(7245), new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(7248), new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(7368), new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(7371), new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(7377), new DateTime(2024, 11, 20, 12, 13, 7, 773, DateTimeKind.Local).AddTicks(7377) });
        }
    }
}
