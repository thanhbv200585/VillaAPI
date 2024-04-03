using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Private pool, Wi-Fi, Air conditioning", new DateTime(2024, 3, 3, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9263), "Spacious luxury villa with stunning ocean views", "https://example.com/images/villa1.jpg", "Luxury Villa", 8, 5.0, 3000, new DateTime(2024, 3, 28, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9277) },
                    { 2, "Garden, BBQ, Beach access", new DateTime(2024, 3, 8, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9284), "Beautiful beachfront villa with direct access to the beach", "https://example.com/images/villa2.jpg", "Beachfront Villa", 6, 4.0, 2500, new DateTime(2024, 3, 30, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9284) },
                    { 3, "Fireplace, Hiking trails", new DateTime(2024, 3, 13, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9286), "Cozy villa nestled in the mountains with scenic views", "https://example.com/images/villa3.jpg", "Mountain Retreat", 4, 3.0, 2000, new DateTime(2024, 3, 31, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9287) },
                    { 4, "Children's playground, Game room", new DateTime(2024, 3, 18, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9288), "Family-friendly villa with a large backyard and play area", "https://example.com/images/villa4.jpg", "Family Villa", 6, 3.5, 2200, new DateTime(2024, 4, 1, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9289) },
                    { 5, "Swimming pool, Gym, Smart home features", new DateTime(2024, 3, 23, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9290), "Stylish and modern villa with contemporary design", "https://example.com/images/villa5.jpg", "Modern Villa", 8, 4.5, 2800, new DateTime(2024, 4, 2, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9291) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
