using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.Net_MVC_Core.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "D_ADDRESS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    province_id = table.Column<int>(type: "int", nullable: false),
                    province_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    district_id = table.Column<int>(type: "int", nullable: false),
                    district_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ward_id = table.Column<int>(type: "int", nullable: false),
                    ward_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ADDRESS", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D_ADDRESS");
        }
    }
}
