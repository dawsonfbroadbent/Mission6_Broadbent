using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6_Broadbent.Migrations
{
    /// <inheritdoc />
    public partial class Updates1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "MovieRatings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "MovieRatings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
