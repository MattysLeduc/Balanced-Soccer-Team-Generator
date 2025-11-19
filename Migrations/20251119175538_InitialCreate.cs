using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Balanced_Soccer_Team_Generator.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BallControl = table.Column<int>(type: "int", nullable: false),
                    PassingAccuracy = table.Column<int>(type: "int", nullable: false),
                    Dribbling = table.Column<int>(type: "int", nullable: false),
                    DefensiveAwareness = table.Column<int>(type: "int", nullable: false),
                    Shooting = table.Column<int>(type: "int", nullable: false),
                    OverallScore = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BallControl", "DefensiveAwareness", "Dribbling", "Name", "OverallScore", "PassingAccuracy", "Rank", "Shooting" },
                values: new object[,]
                {
                    { 1, 8, 6, 8, "Alex", 0, 7, 0, 7 },
                    { 2, 6, 7, 7, "Blake", 0, 6, 0, 6 },
                    { 3, 9, 7, 8, "Casey", 0, 8, 0, 9 },
                    { 4, 5, 5, 5, "Drew", 0, 5, 0, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
