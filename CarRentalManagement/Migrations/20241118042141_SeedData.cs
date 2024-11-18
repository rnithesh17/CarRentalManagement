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
                    { 1, "System", new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4663), new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4675), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4678), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4899), new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4900), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4902), new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4903), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4995), new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4995), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4997), new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4998), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(4999), new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(5000), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(5001), new DateTime(2024, 11, 18, 12, 21, 40, 688, DateTimeKind.Local).AddTicks(5002), "C-HR", "System" }
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
