using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.App.Web.Migrations
{
    public partial class MyFirstMigration0224003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BASE_DEPARTMENT_BaseCompany_CompanyId",
                table: "BASE_DEPARTMENT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseCompany",
                table: "BaseCompany");

            migrationBuilder.RenameTable(
                name: "BaseCompany",
                newName: "BASE_COMPANY");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BASE_COMPANY",
                table: "BASE_COMPANY",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SYS_ROLEMENU",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MenuId = table.Column<int>(nullable: false),
                    RecordDate = table.Column<DateTime>(nullable: false),
                    RecordId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_ROLEMENU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYS_USERROLE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeleteFlag = table.Column<int>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_USERROLE", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BASE_DEPARTMENT_BASE_COMPANY_CompanyId",
                table: "BASE_DEPARTMENT",
                column: "CompanyId",
                principalTable: "BASE_COMPANY",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BASE_DEPARTMENT_BASE_COMPANY_CompanyId",
                table: "BASE_DEPARTMENT");

            migrationBuilder.DropTable(
                name: "SYS_ROLEMENU");

            migrationBuilder.DropTable(
                name: "SYS_USERROLE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BASE_COMPANY",
                table: "BASE_COMPANY");

            migrationBuilder.RenameTable(
                name: "BASE_COMPANY",
                newName: "BaseCompany");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseCompany",
                table: "BaseCompany",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BASE_DEPARTMENT_BaseCompany_CompanyId",
                table: "BASE_DEPARTMENT",
                column: "CompanyId",
                principalTable: "BaseCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
