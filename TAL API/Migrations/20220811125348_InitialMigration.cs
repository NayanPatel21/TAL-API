using Microsoft.EntityFrameworkCore.Migrations;

namespace TAL_API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OccupationRating",
                columns: table => new
                {
                    OccupationRatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccupationRatingName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Factor = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationRating", x => x.OccupationRatingId);
                });

            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    OccupationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccupationName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    OccupationRatingRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.OccupationId);
                    table.ForeignKey(
                        name: "FK_Occupations_OccupationRating_OccupationRatingRefId",
                        column: x => x.OccupationRatingRefId,
                        principalTable: "OccupationRating",
                        principalColumn: "OccupationRatingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OccupationRating",
                columns: new[] { "OccupationRatingId", "Factor", "OccupationRatingName" },
                values: new object[,]
                {
                    { 1, 1.0m, "Professional" },
                    { 2, 1.25m, "White Collar" },
                    { 3, 1.50m, "Light Manual" },
                    { 4, 1.75m, "Heavy Manual" }
                });

            migrationBuilder.InsertData(
                table: "Occupations",
                columns: new[] { "OccupationId", "OccupationName", "OccupationRatingRefId" },
                values: new object[,]
                {
                    { 2, "Doctor", 1 },
                    { 3, "Author", 2 },
                    { 1, "Cleaner", 3 },
                    { 6, "Florist", 3 },
                    { 4, "Farmer", 4 },
                    { 5, "Mechanic", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Occupations_OccupationRatingRefId",
                table: "Occupations",
                column: "OccupationRatingRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Occupations");

            migrationBuilder.DropTable(
                name: "OccupationRating");
        }
    }
}
