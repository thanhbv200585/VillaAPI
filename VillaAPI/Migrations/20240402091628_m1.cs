using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 3, 16, 16, 28, 292, DateTimeKind.Local).AddTicks(9482), new DateTime(2024, 3, 28, 16, 16, 28, 292, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 8, 16, 16, 28, 292, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 3, 30, 16, 16, 28, 292, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 16, 28, 292, DateTimeKind.Local).AddTicks(9527), new DateTime(2024, 3, 31, 16, 16, 28, 292, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 16, 28, 292, DateTimeKind.Local).AddTicks(9531), new DateTime(2024, 4, 1, 16, 16, 28, 292, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 16, 28, 292, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 4, 2, 16, 16, 28, 292, DateTimeKind.Local).AddTicks(9537) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 3, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9263), new DateTime(2024, 3, 28, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 8, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9284), new DateTime(2024, 3, 30, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9286), new DateTime(2024, 3, 31, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9288), new DateTime(2024, 4, 1, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9290), new DateTime(2024, 4, 2, 14, 32, 19, 792, DateTimeKind.Local).AddTicks(9291) });
        }
    }
}
