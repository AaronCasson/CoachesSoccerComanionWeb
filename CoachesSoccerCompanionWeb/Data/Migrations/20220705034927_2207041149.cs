using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoachesSoccerCompanionWeb.Data.Migrations
{
    public partial class _2207041149 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamName",
                table: "Participants");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeamName",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
