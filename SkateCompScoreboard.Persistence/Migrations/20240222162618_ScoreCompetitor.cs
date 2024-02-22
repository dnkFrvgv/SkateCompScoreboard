using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkateCompScoreboard.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ScoreCompetitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_RoundCompetitors_CompetitorRoundId_CompetitorId1",
                table: "Scores");

            migrationBuilder.RenameColumn(
                name: "CompetitorRoundId",
                table: "Scores",
                newName: "RoundCompetitorRoundId");

            migrationBuilder.RenameColumn(
                name: "CompetitorId1",
                table: "Scores",
                newName: "RoundCompetitorCompetitorId");

            migrationBuilder.RenameColumn(
                name: "CompetitorId",
                table: "Scores",
                newName: "RoundCompetitorId");

            migrationBuilder.RenameIndex(
                name: "IX_Scores_CompetitorRoundId_CompetitorId1",
                table: "Scores",
                newName: "IX_Scores_RoundCompetitorRoundId_RoundCompetitorCompetitorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_RoundCompetitors_RoundCompetitorRoundId_RoundCompetitorCompetitorId",
                table: "Scores",
                columns: new[] { "RoundCompetitorRoundId", "RoundCompetitorCompetitorId" },
                principalTable: "RoundCompetitors",
                principalColumns: new[] { "RoundId", "CompetitorId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_RoundCompetitors_RoundCompetitorRoundId_RoundCompetitorCompetitorId",
                table: "Scores");

            migrationBuilder.RenameColumn(
                name: "RoundCompetitorRoundId",
                table: "Scores",
                newName: "CompetitorRoundId");

            migrationBuilder.RenameColumn(
                name: "RoundCompetitorId",
                table: "Scores",
                newName: "CompetitorId");

            migrationBuilder.RenameColumn(
                name: "RoundCompetitorCompetitorId",
                table: "Scores",
                newName: "CompetitorId1");

            migrationBuilder.RenameIndex(
                name: "IX_Scores_RoundCompetitorRoundId_RoundCompetitorCompetitorId",
                table: "Scores",
                newName: "IX_Scores_CompetitorRoundId_CompetitorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_RoundCompetitors_CompetitorRoundId_CompetitorId1",
                table: "Scores",
                columns: new[] { "CompetitorRoundId", "CompetitorId1" },
                principalTable: "RoundCompetitors",
                principalColumns: new[] { "RoundId", "CompetitorId" });
        }
    }
}
