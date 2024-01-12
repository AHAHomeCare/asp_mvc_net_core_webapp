using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.Net_MVC_Core.Migrations
{
    public partial class init_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_STUDENT_D_STUDENT_Studentid",
                table: "D_STUDENT");

            migrationBuilder.DropForeignKey(
                name: "FK_D_STUDENT_MARK_D_STUDENT_studentid",
                table: "D_STUDENT_MARK");

            migrationBuilder.DropIndex(
                name: "IX_D_STUDENT_Studentid",
                table: "D_STUDENT");

            migrationBuilder.DropColumn(
                name: "Studentid",
                table: "D_STUDENT");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "D_ADDRESS");

            migrationBuilder.AlterColumn<int>(
                name: "studentid",
                table: "D_STUDENT_MARK",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_D_STUDENT_MARK_D_STUDENT_studentid",
                table: "D_STUDENT_MARK",
                column: "studentid",
                principalTable: "D_STUDENT",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_STUDENT_MARK_D_STUDENT_studentid",
                table: "D_STUDENT_MARK");

            migrationBuilder.AlterColumn<int>(
                name: "studentid",
                table: "D_STUDENT_MARK",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Studentid",
                table: "D_STUDENT",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "updated_by",
                table: "D_ADDRESS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_D_STUDENT_Studentid",
                table: "D_STUDENT",
                column: "Studentid");

            migrationBuilder.AddForeignKey(
                name: "FK_D_STUDENT_D_STUDENT_Studentid",
                table: "D_STUDENT",
                column: "Studentid",
                principalTable: "D_STUDENT",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_D_STUDENT_MARK_D_STUDENT_studentid",
                table: "D_STUDENT_MARK",
                column: "studentid",
                principalTable: "D_STUDENT",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
