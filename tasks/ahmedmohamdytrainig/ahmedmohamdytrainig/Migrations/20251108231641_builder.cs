using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ahmedmohamdytrainig.Migrations
{
    /// <inheritdoc />
    public partial class builder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Des",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Des",
                table: "Departments");
        }
    }
}
