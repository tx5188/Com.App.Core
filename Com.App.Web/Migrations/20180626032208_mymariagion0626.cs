using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.App.Web.Migrations
{
    public partial class mymariagion0626 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BASE_COMPANY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    CompanyCode = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Contacts = table.Column<string>(nullable: true),
                    DeleteFlag = table.Column<int>(nullable: false),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CheckMan = table.Column<string>(nullable: true),
                    CheckDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_COMPANY", x => x.Id);
                });

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
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CheckMan = table.Column<string>(nullable: true),
                    CheckDate = table.Column<DateTime>(nullable: true)
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
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CheckMan = table.Column<string>(nullable: true),
                    CheckDate = table.Column<DateTime>(nullable: true)
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
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_DICTIONARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYS_MENU",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MenuName = table.Column<string>(nullable: true),
                    MenuCode = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Target = table.Column<string>(nullable: true),
                    IsOperate = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    IsShow = table.Column<int>(nullable: false),
                    MenuOrder = table.Column<int>(nullable: false),
                    Img = table.Column<string>(nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    DeleteFlag = table.Column<int>(nullable: false),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
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
                    RoleName = table.Column<int>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    DeleteFlag = table.Column<int>(nullable: false),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_ROLE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYS_ROLEMENU",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    MenuId = table.Column<int>(nullable: false),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
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
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    DeleteFlag = table.Column<int>(nullable: false),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_USERROLE", x => x.Id);
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
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CheckMan = table.Column<string>(nullable: true),
                    CheckDate = table.Column<DateTime>(nullable: true)
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
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CheckMan = table.Column<string>(nullable: true),
                    CheckDate = table.Column<DateTime>(nullable: true)
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
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CheckMan = table.Column<string>(nullable: true),
                    CheckDate = table.Column<DateTime>(nullable: true),
                    Memo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASK_TESTPLAN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BASE_DEPARTMENT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<int>(nullable: false),
                    DeptName = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    DeptCode = table.Column<string>(nullable: true),
                    DepteType = table.Column<int>(nullable: false),
                    DeptLevel = table.Column<int>(nullable: false),
                    DeleteFlag = table.Column<int>(nullable: false),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CheckMan = table.Column<string>(nullable: true),
                    CheckDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BASE_DEPARTMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BASE_DEPARTMENT_BASE_COMPANY_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "BASE_COMPANY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SYS_USER",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeptId = table.Column<int>(nullable: false),
                    UserNo = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    DeleteFlag = table.Column<int>(nullable: false),
                    RecordMan = table.Column<string>(nullable: true),
                    RecordDate = table.Column<DateTime>(nullable: true),
                    UpdateMan = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
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
                name: "IX_BASE_DEPARTMENT_CompanyId",
                table: "BASE_DEPARTMENT",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_SYS_USER_DeptId",
                table: "SYS_USER",
                column: "DeptId");
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
                name: "SYS_MENU");

            migrationBuilder.DropTable(
                name: "SYS_ROLE");

            migrationBuilder.DropTable(
                name: "SYS_ROLEMENU");

            migrationBuilder.DropTable(
                name: "SYS_USER");

            migrationBuilder.DropTable(
                name: "SYS_USERROLE");

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

            migrationBuilder.DropTable(
                name: "BASE_DEPARTMENT");

            migrationBuilder.DropTable(
                name: "BASE_COMPANY");
        }
    }
}
