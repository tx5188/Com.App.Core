using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.App.Web.Migrations
{
    public partial class MyFirstMigration0224002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MenuName",
                table: "SYS_MENU",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "SYS_MENU",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsOperate",
                table: "SYS_MENU",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsShow",
                table: "SYS_MENU",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MenuCode",
                table: "SYS_MENU",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "SYS_MENU",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "SYS_MENU",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Target",
                table: "SYS_MENU",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "SYS_MENU",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "BASE_DEPARTMENT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BaseCompany",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    CompanyCode = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    Contacts = table.Column<string>(nullable: true),
                    DeleteFlag = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseCompany", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BASE_DEPARTMENT_CompanyId",
                table: "BASE_DEPARTMENT",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BASE_DEPARTMENT_BaseCompany_CompanyId",
                table: "BASE_DEPARTMENT",
                column: "CompanyId",
                principalTable: "BaseCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BASE_DEPARTMENT_BaseCompany_CompanyId",
                table: "BASE_DEPARTMENT");

            migrationBuilder.DropTable(
                name: "BaseCompany");

            migrationBuilder.DropIndex(
                name: "IX_BASE_DEPARTMENT_CompanyId",
                table: "BASE_DEPARTMENT");

            migrationBuilder.DropColumn(
                name: "Img",
                table: "SYS_MENU");

            migrationBuilder.DropColumn(
                name: "IsOperate",
                table: "SYS_MENU");

            migrationBuilder.DropColumn(
                name: "IsShow",
                table: "SYS_MENU");

            migrationBuilder.DropColumn(
                name: "MenuCode",
                table: "SYS_MENU");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "SYS_MENU");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "SYS_MENU");

            migrationBuilder.DropColumn(
                name: "Target",
                table: "SYS_MENU");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "SYS_MENU");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "BASE_DEPARTMENT");

            migrationBuilder.AlterColumn<int>(
                name: "MenuName",
                table: "SYS_MENU",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
