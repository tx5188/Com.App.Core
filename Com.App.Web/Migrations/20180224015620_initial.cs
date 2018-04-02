using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.App.Web.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BASE_DEPARTMENT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeleteFlag = table.Column<int>(nullable: false),
                    DeptCode = table.Column<string>(nullable: true),
                    DeptLevel = table.Column<int>(nullable: false),
                    DeptName = table.Column<string>(nullable: true),
                    DepteType = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_DEPARTMENT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYS_MENU",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeleteFlag = table.Column<int>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    MenuName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_MENU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYS_ROLE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeleteFlag = table.Column<int>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    RoleName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_ROLE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYS_USER",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeleteFlag = table.Column<int>(nullable: false),
                    DeptId = table.Column<int>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    UserNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_USER", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SYS_USER_BASE_DEPARTMENT_DeptId",
                        column: x => x.DeptId,
                        principalTable: "BASE_DEPARTMENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SYS_USER_DeptId",
                table: "SYS_USER",
                column: "DeptId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SYS_MENU");

            migrationBuilder.DropTable(
                name: "SYS_ROLE");

            migrationBuilder.DropTable(
                name: "SYS_USER");

            migrationBuilder.DropTable(
                name: "BASE_DEPARTMENT");
        }
    }
}
