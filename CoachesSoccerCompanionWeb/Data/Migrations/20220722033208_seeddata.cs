using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoachesSoccerCompanionWeb.Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "Discriminator", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("c7012bd4-79ae-4835-be3f-3bf3fc43c60e"), "Coach", "SeedFirstName", "SeedLastName", "555-555-5555" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("c7012bd4-79ae-4835-be3f-3bf3fc43c60e"));
        }
    }
}
