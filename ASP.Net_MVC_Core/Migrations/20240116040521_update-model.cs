using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.Net_MVC_Core.Migrations
{
    public partial class updatemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_STUDENT_D_ADDRESS_addressid",
                table: "D_STUDENT");

            migrationBuilder.DropForeignKey(
                name: "FK_D_STUDENT_CALENDAR_D_STUDENT_Studentid",
                table: "D_STUDENT_CALENDAR");

            migrationBuilder.DropForeignKey(
                name: "FK_D_STUDENT_CALENDAR_D_SUBJECT_Subjectid",
                table: "D_STUDENT_CALENDAR");

            migrationBuilder.DropForeignKey(
                name: "FK_D_STUDENT_MARK_D_STUDENT_studentid",
                table: "D_STUDENT_MARK");

            migrationBuilder.DropForeignKey(
                name: "FK_D_STUDENT_MARK_D_SUBJECT_subjectid",
                table: "D_STUDENT_MARK");

            migrationBuilder.DropIndex(
                name: "IX_D_STUDENT_MARK_subjectid",
                table: "D_STUDENT_MARK");

            migrationBuilder.DropIndex(
                name: "IX_D_STUDENT_CALENDAR_Subjectid",
                table: "D_STUDENT_CALENDAR");

            migrationBuilder.DropIndex(
                name: "IX_D_STUDENT_addressid",
                table: "D_STUDENT");

            migrationBuilder.DropColumn(
                name: "subjectid",
                table: "D_STUDENT_MARK");

            migrationBuilder.DropColumn(
                name: "Subjectid",
                table: "D_STUDENT_CALENDAR");

            migrationBuilder.DropColumn(
                name: "addressid",
                table: "D_STUDENT");

            migrationBuilder.RenameColumn(
                name: "studentid",
                table: "D_STUDENT_MARK",
                newName: "Studentid");

            migrationBuilder.RenameIndex(
                name: "IX_D_STUDENT_MARK_studentid",
                table: "D_STUDENT_MARK",
                newName: "IX_D_STUDENT_MARK_Studentid");

            migrationBuilder.AlterColumn<int>(
                name: "Studentid",
                table: "D_STUDENT_MARK",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Studentid",
                table: "D_STUDENT_CALENDAR",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ward_name",
                table: "D_ADDRESS",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "province_name",
                table: "D_ADDRESS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_D_STUDENT_CALENDAR_D_STUDENT_Studentid",
                table: "D_STUDENT_CALENDAR",
                column: "Studentid",
                principalTable: "D_STUDENT",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_D_STUDENT_MARK_D_STUDENT_Studentid",
                table: "D_STUDENT_MARK",
                column: "Studentid",
                principalTable: "D_STUDENT",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_STUDENT_CALENDAR_D_STUDENT_Studentid",
                table: "D_STUDENT_CALENDAR");

            migrationBuilder.DropForeignKey(
                name: "FK_D_STUDENT_MARK_D_STUDENT_Studentid",
                table: "D_STUDENT_MARK");

            migrationBuilder.RenameColumn(
                name: "Studentid",
                table: "D_STUDENT_MARK",
                newName: "studentid");

            migrationBuilder.RenameIndex(
                name: "IX_D_STUDENT_MARK_Studentid",
                table: "D_STUDENT_MARK",
                newName: "IX_D_STUDENT_MARK_studentid");

            migrationBuilder.AlterColumn<int>(
                name: "studentid",
                table: "D_STUDENT_MARK",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "subjectid",
                table: "D_STUDENT_MARK",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Studentid",
                table: "D_STUDENT_CALENDAR",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Subjectid",
                table: "D_STUDENT_CALENDAR",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "addressid",
                table: "D_STUDENT",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ward_name",
                table: "D_ADDRESS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "province_name",
                table: "D_ADDRESS",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_D_STUDENT_MARK_subjectid",
                table: "D_STUDENT_MARK",
                column: "subjectid");

            migrationBuilder.CreateIndex(
                name: "IX_D_STUDENT_CALENDAR_Subjectid",
                table: "D_STUDENT_CALENDAR",
                column: "Subjectid");

            migrationBuilder.CreateIndex(
                name: "IX_D_STUDENT_addressid",
                table: "D_STUDENT",
                column: "addressid");

            migrationBuilder.AddForeignKey(
                name: "FK_D_STUDENT_D_ADDRESS_addressid",
                table: "D_STUDENT",
                column: "addressid",
                principalTable: "D_ADDRESS",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_D_STUDENT_CALENDAR_D_STUDENT_Studentid",
                table: "D_STUDENT_CALENDAR",
                column: "Studentid",
                principalTable: "D_STUDENT",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_D_STUDENT_CALENDAR_D_SUBJECT_Subjectid",
                table: "D_STUDENT_CALENDAR",
                column: "Subjectid",
                principalTable: "D_SUBJECT",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_D_STUDENT_MARK_D_STUDENT_studentid",
                table: "D_STUDENT_MARK",
                column: "studentid",
                principalTable: "D_STUDENT",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_D_STUDENT_MARK_D_SUBJECT_subjectid",
                table: "D_STUDENT_MARK",
                column: "subjectid",
                principalTable: "D_SUBJECT",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
