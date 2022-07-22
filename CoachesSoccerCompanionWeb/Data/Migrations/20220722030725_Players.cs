using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoachesSoccerCompanionWeb.Data.Migrations
{
    public partial class Players : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PositionTime",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaytimeStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlaytimeEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: true),
                    TimePlayed = table.Column<double>(type: "float", nullable: true),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PositionTime_Participants_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Participants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Participants_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Participants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participants_TeamId",
                table: "Participants",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionTime_PlayerId",
                table: "PositionTime",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CoachId",
                table: "Teams",
                column: "CoachId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Teams_TeamId",
                table: "Participants",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Teams_TeamId",
                table: "Participants");

            migrationBuilder.DropTable(
                name: "PositionTime");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Participants");
        }
    }
}
