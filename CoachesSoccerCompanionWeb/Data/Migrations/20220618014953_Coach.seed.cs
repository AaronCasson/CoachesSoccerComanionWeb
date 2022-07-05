using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoachesSoccerCompanionWeb.Data.Migrations
{
    public partial class Coachseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "Discriminator", "FirstName", "LastName", "PhoneNumber", "TeamName" },
                values: new object[] { new Guid("d2c47348-101f-4d9b-ac63-aa07af9e029c"), "Coach", "Aaron", "Casson", "555-555-5555", "Dragons" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("d2c47348-101f-4d9b-ac63-aa07af9e029c"));

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Participants");
        }
    }
}
