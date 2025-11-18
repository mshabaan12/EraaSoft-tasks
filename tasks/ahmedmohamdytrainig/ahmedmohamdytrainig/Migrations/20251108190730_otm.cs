using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ahmedmohamdytrainig.Migrations
{
    /// <inheritdoc />
    public partial class otm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Grads_StudentId",
                table: "Grads");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Students",
                newName: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentID",
                table: "Students",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Grads_StudentId",
                table: "Grads",
                column: "StudentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentID",
                table: "Students",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Grads_StudentId",
                table: "Grads");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Students",
                newName: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Grads_StudentId",
                table: "Grads",
                column: "StudentId");
        }
    }
}
