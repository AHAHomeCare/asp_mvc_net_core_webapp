using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.Net_MVC_Core.Migrations
{
    public partial class update_model_student_calendar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "D_STUDENT_CALENDAR",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject_id = table.Column<int>(type: "int", nullable: false),
                    Subjectid = table.Column<int>(type: "int", nullable: true),
                    student_id = table.Column<int>(type: "int", nullable: false),
                    Studentid = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_STUDENT_CALENDAR", x => x.id);
                    table.ForeignKey(
                        name: "FK_D_STUDENT_CALENDAR_D_STUDENT_Studentid",
                        column: x => x.Studentid,
                        principalTable: "D_STUDENT",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_D_STUDENT_CALENDAR_D_SUBJECT_Subjectid",
                        column: x => x.Subjectid,
                        principalTable: "D_SUBJECT",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_D_STUDENT_CALENDAR_Studentid",
                table: "D_STUDENT_CALENDAR",
                column: "Studentid");

            migrationBuilder.CreateIndex(
                name: "IX_D_STUDENT_CALENDAR_Subjectid",
                table: "D_STUDENT_CALENDAR",
                column: "Subjectid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D_STUDENT_CALENDAR");
        }
    }
}
