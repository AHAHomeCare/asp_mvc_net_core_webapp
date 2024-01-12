using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.Net_MVC_Core.Migrations
{
    public partial class init_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "D_STUDENT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    cccd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address_id = table.Column<int>(type: "int", nullable: false),
                    addressid = table.Column<int>(type: "int", nullable: true),
                    Studentid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_STUDENT", x => x.id);
                    table.ForeignKey(
                        name: "FK_D_STUDENT_D_ADDRESS_addressid",
                        column: x => x.addressid,
                        principalTable: "D_ADDRESS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_D_STUDENT_D_STUDENT_Studentid",
                        column: x => x.Studentid,
                        principalTable: "D_STUDENT",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "D_STUDENT_MARK",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentid = table.Column<int>(type: "int", nullable: true),
                    subject_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subjectid = table.Column<int>(type: "int", nullable: true),
                    mark = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_STUDENT_MARK", x => x.id);
                    table.ForeignKey(
                        name: "FK_D_STUDENT_MARK_D_STUDENT_studentid",
                        column: x => x.studentid,
                        principalTable: "D_STUDENT",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_D_STUDENT_MARK_Subject_subjectid",
                        column: x => x.subjectid,
                        principalTable: "Subject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_D_STUDENT_addressid",
                table: "D_STUDENT",
                column: "addressid");

            migrationBuilder.CreateIndex(
                name: "IX_D_STUDENT_Studentid",
                table: "D_STUDENT",
                column: "Studentid");

            migrationBuilder.CreateIndex(
                name: "IX_D_STUDENT_MARK_studentid",
                table: "D_STUDENT_MARK",
                column: "studentid");

            migrationBuilder.CreateIndex(
                name: "IX_D_STUDENT_MARK_subjectid",
                table: "D_STUDENT_MARK",
                column: "subjectid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D_STUDENT_MARK");

            migrationBuilder.DropTable(
                name: "D_STUDENT");

            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
