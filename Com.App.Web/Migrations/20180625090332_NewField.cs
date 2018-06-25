using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.App.Web.Migrations
{
    public partial class NewField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecordId",
                table: "SYS_ROLEMENU");

            migrationBuilder.AddColumn<DateTime>(
                name: "RecordDate",
                table: "SYS_USERROLE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RecordMan",
                table: "SYS_USERROLE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "SYS_USERROLE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateMan",
                table: "SYS_USERROLE",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserNo",
                table: "SYS_USER",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RecordDate",
                table: "SYS_USER",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RecordMan",
                table: "SYS_USER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "SYS_USER",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateMan",
                table: "SYS_USER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecordMan",
                table: "SYS_ROLEMENU",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RecordDate",
                table: "SYS_ROLE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RecordMan",
                table: "SYS_ROLE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "SYS_ROLE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateMan",
                table: "SYS_ROLE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RecordDate",
                table: "SYS_MENU",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RecordMan",
                table: "SYS_MENU",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "SYS_MENU",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateMan",
                table: "SYS_MENU",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RecordDate",
                table: "BASE_DEPARTMENT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RecordMan",
                table: "BASE_DEPARTMENT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "BASE_DEPARTMENT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateMan",
                table: "BASE_DEPARTMENT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RecordDate",
                table: "BASE_COMPANY",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RecordMan",
                table: "BASE_COMPANY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "BASE_COMPANY",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateMan",
                table: "BASE_COMPANY",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BASE_SAMPPOINT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SampPointName = table.Column<string>(nullable: true),
                    SampPointCode = table.Column<string>(nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    DeleteFlag = table.Column<int>(nullable: false),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: false),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_SAMPPOINT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BASE_WATERTYPE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WaterTypeName = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    WaterTypeOrder = table.Column<int>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    DeleteFlag = table.Column<int>(nullable: false),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: false),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_WATERTYPE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYS_DICTIONARY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DicType = table.Column<string>(nullable: true),
                    DicCode = table.Column<string>(nullable: true),
                    DicName = table.Column<string>(nullable: true),
                    DicOrder = table.Column<int>(nullable: false),
                    DicMemo = table.Column<string>(nullable: true),
                    DeleteFlag = table.Column<int>(nullable: false),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: false),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_DICTIONARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TASK_SAMPLINPLAN",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeptId = table.Column<int>(nullable: false),
                    TaskFrom = table.Column<string>(nullable: true),
                    PlanDate = table.Column<DateTime>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: false),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    CheckMan = table.Column<string>(nullable: true),
                    CheckDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASK_SAMPLINPLAN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TASK_SAMPLINPLAN_DETAIL",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SampId = table.Column<int>(nullable: false),
                    GroupName = table.Column<string>(nullable: true),
                    SamplingMan = table.Column<string>(nullable: true),
                    Vehicle = table.Column<string>(nullable: true),
                    Equipment = table.Column<string>(nullable: true),
                    PointId = table.Column<int>(nullable: false),
                    LeaveTime = table.Column<DateTime>(nullable: false),
                    BackTime = table.Column<DateTime>(nullable: false),
                    Memo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASK_SAMPLINPLAN_DETAIL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TASK_TESTNOTICE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeptId = table.Column<int>(nullable: false),
                    SampDate = table.Column<DateTime>(nullable: false),
                    SampleTypeId = table.Column<DateTime>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: false),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    CheckMan = table.Column<string>(nullable: true),
                    CheckDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASK_TESTNOTICE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TASK_TESTNOTICE_DETAIL",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TestTaskId = table.Column<int>(nullable: false),
                    TestProject = table.Column<string>(nullable: true),
                    TestSampleNum = table.Column<int>(nullable: false),
                    PointId = table.Column<int>(nullable: false),
                    AnalysisMethod = table.Column<string>(nullable: true),
                    TestFinishTime = table.Column<string>(nullable: true),
                    TestMan = table.Column<string>(nullable: true),
                    Memo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASK_TESTNOTICE_DETAIL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TASK_TESTPLAN",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeptId = table.Column<int>(nullable: false),
                    TaskName = table.Column<string>(nullable: true),
                    TaskCode = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    TestRange = table.Column<string>(nullable: true),
                    TestObjective = table.Column<string>(nullable: true),
                    TestBasis = table.Column<string>(nullable: true),
                    QualityControleIn = table.Column<string>(nullable: true),
                    QualityControleOut = table.Column<string>(nullable: true),
                    BegDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Participants = table.Column<string>(nullable: true),
                    ResultsForm = table.Column<string>(nullable: true),
                    TechnicalLeader = table.Column<string>(nullable: true),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: false),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    CheckMan = table.Column<string>(nullable: true),
                    CheckDate = table.Column<DateTime>(nullable: false),
                    Memo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASK_TESTPLAN", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BASE_SAMPPOINT");

            migrationBuilder.DropTable(
                name: "BASE_WATERTYPE");

            migrationBuilder.DropTable(
                name: "SYS_DICTIONARY");

            migrationBuilder.DropTable(
                name: "TASK_SAMPLINPLAN");

            migrationBuilder.DropTable(
                name: "TASK_SAMPLINPLAN_DETAIL");

            migrationBuilder.DropTable(
                name: "TASK_TESTNOTICE");

            migrationBuilder.DropTable(
                name: "TASK_TESTNOTICE_DETAIL");

            migrationBuilder.DropTable(
                name: "TASK_TESTPLAN");

            migrationBuilder.DropColumn(
                name: "RecordDate",
                table: "SYS_USERROLE");

            migrationBuilder.DropColumn(
                name: "RecordMan",
                table: "SYS_USERROLE");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "SYS_USERROLE");

            migrationBuilder.DropColumn(
                name: "UpdateMan",
                table: "SYS_USERROLE");

            migrationBuilder.DropColumn(
                name: "RecordDate",
                table: "SYS_USER");

            migrationBuilder.DropColumn(
                name: "RecordMan",
                table: "SYS_USER");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "SYS_USER");

            migrationBuilder.DropColumn(
                name: "UpdateMan",
                table: "SYS_USER");

            migrationBuilder.DropColumn(
                name: "RecordMan",
                table: "SYS_ROLEMENU");

            migrationBuilder.DropColumn(
                name: "RecordDate",
                table: "SYS_ROLE");

            migrationBuilder.DropColumn(
                name: "RecordMan",
                table: "SYS_ROLE");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "SYS_ROLE");

            migrationBuilder.DropColumn(
                name: "UpdateMan",
                table: "SYS_ROLE");

            migrationBuilder.DropColumn(
                name: "RecordDate",
                table: "SYS_MENU");

            migrationBuilder.DropColumn(
                name: "RecordMan",
                table: "SYS_MENU");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "SYS_MENU");

            migrationBuilder.DropColumn(
                name: "UpdateMan",
                table: "SYS_MENU");

            migrationBuilder.DropColumn(
                name: "RecordDate",
                table: "BASE_DEPARTMENT");

            migrationBuilder.DropColumn(
                name: "RecordMan",
                table: "BASE_DEPARTMENT");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "BASE_DEPARTMENT");

            migrationBuilder.DropColumn(
                name: "UpdateMan",
                table: "BASE_DEPARTMENT");

            migrationBuilder.DropColumn(
                name: "RecordDate",
                table: "BASE_COMPANY");

            migrationBuilder.DropColumn(
                name: "RecordMan",
                table: "BASE_COMPANY");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "BASE_COMPANY");

            migrationBuilder.DropColumn(
                name: "UpdateMan",
                table: "BASE_COMPANY");

            migrationBuilder.AlterColumn<string>(
                name: "UserNo",
                table: "SYS_USER",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "RecordId",
                table: "SYS_ROLEMENU",
                nullable: false,
                defaultValue: 0);
        }
    }
}
