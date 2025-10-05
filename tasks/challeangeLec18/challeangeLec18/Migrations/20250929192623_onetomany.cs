using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace challeangeLec18.Migrations
{
    /// <inheritdoc />
    public partial class onetomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_Officers_OfficerId",
                table: "Specialties");

            migrationBuilder.DropIndex(
                name: "IX_Specialties_OfficerId",
                table: "Specialties");

            migrationBuilder.AddColumn<int>(
                name: "specialtyId",
                table: "Officers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Officers_specialtyId",
                table: "Officers",
                column: "specialtyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Officers_Specialties_specialtyId",
                table: "Officers",
                column: "specialtyId",
                principalTable: "Specialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Officers_Specialties_specialtyId",
                table: "Officers");

            migrationBuilder.DropIndex(
                name: "IX_Officers_specialtyId",
                table: "Officers");

            migrationBuilder.DropColumn(
                name: "specialtyId",
                table: "Officers");

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_OfficerId",
                table: "Specialties",
                column: "OfficerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_Officers_OfficerId",
                table: "Specialties",
                column: "OfficerId",
                principalTable: "Officers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
