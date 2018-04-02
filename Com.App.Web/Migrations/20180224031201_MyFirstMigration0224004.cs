using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.App.Web.Migrations
{
    public partial class MyFirstMigration0224004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Order",
                table: "SYS_MENU",
                newName: "MenuOrder");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MenuOrder",
                table: "SYS_MENU",
                newName: "Order");
        }
    }
}
