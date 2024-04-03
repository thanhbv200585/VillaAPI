using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddUserToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 3, 28, 511, DateTimeKind.Local).AddTicks(1597), new DateTime(2024, 3, 29, 14, 3, 28, 511, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 9, 14, 3, 28, 511, DateTimeKind.Local).AddTicks(1618), new DateTime(2024, 3, 31, 14, 3, 28, 511, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 3, 28, 511, DateTimeKind.Local).AddTicks(1620), new DateTime(2024, 4, 1, 14, 3, 28, 511, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 19, 14, 3, 28, 511, DateTimeKind.Local).AddTicks(1622), new DateTime(2024, 4, 2, 14, 3, 28, 511, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 24, 14, 3, 28, 511, DateTimeKind.Local).AddTicks(1624), new DateTime(2024, 4, 3, 14, 3, 28, 511, DateTimeKind.Local).AddTicks(1625) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 3, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3162), new DateTime(2024, 3, 28, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 8, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3212), new DateTime(2024, 3, 30, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3220), new DateTime(2024, 3, 31, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3226), new DateTime(2024, 4, 1, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3234), new DateTime(2024, 4, 2, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3236) });
        }
    }
}
