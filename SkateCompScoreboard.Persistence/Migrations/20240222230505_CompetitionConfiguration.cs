using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SkateCompScoreboard.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CompetitionConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competitions_Addresses_PlaceId",
                table: "Competitions");

            migrationBuilder.RenameColumn(
                name: "StartDateTime",
                table: "Competitions",
                newName: "OpenningDate");

            migrationBuilder.RenameColumn(
                name: "PlaceId",
                table: "Competitions",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Competitions_PlaceId",
                table: "Competitions",
                newName: "IX_Competitions_AddressId");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRounds",
                table: "Competitions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "Id", "AddressId", "Category", "Description", "Modality", "Name", "NumberOfRounds", "OpenningDate", "Status" },
                values: new object[,]
                {
                    { new Guid("7f985804-d3ef-4816-8876-48eb5de6b134"), null, "f", null, 0, "SLS Sidney 2024: Women's Tournament", 3, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("996eecb7-3ca5-4546-b157-dadc0accbd1e"), null, "m", null, 2, "XGames Japan 2024: Man's Vert", 2, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("c96cc4b3-b405-4dc9-b2b4-650b9300ff3a"), null, "f", null, 1, "XGames Japan 2024: Women's Park", 3, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Competitions_Addresses_AddressId",
                table: "Competitions",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competitions_Addresses_AddressId",
                table: "Competitions");

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("7f985804-d3ef-4816-8876-48eb5de6b134"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("996eecb7-3ca5-4546-b157-dadc0accbd1e"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("c96cc4b3-b405-4dc9-b2b4-650b9300ff3a"));

            migrationBuilder.DropColumn(
                name: "NumberOfRounds",
                table: "Competitions");

            migrationBuilder.RenameColumn(
                name: "OpenningDate",
                table: "Competitions",
                newName: "StartDateTime");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Competitions",
                newName: "PlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Competitions_AddressId",
                table: "Competitions",
                newName: "IX_Competitions_PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Competitions_Addresses_PlaceId",
                table: "Competitions",
                column: "PlaceId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }
    }
}
