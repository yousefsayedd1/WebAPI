using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_API_Day_2.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Courseid",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Courseid",
                table: "Students",
                column: "Courseid");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_Courseid",
                table: "Students",
                column: "Courseid",
                principalTable: "Courses",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_Courseid",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Courseid",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Courseid",
                table: "Students");
        }
    }
}
