﻿// <auto-generated />
using System;
using Com.App.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Com.App.Web.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20180626032208_mymariagion0626")]
    partial class mymariagion0626
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.App.Model.Base.BaseCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime?>("CheckDate");

                    b.Property<string>("CheckMan");

                    b.Property<string>("CompanyCode");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Contacts");

                    b.Property<int>("DeleteFlag");

                    b.Property<string>("Phone");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.HasKey("Id");

                    b.ToTable("BASE_COMPANY");
                });

            modelBuilder.Entity("Com.App.Model.Base.BaseDeparment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CheckDate");

                    b.Property<string>("CheckMan");

                    b.Property<int>("CompanyId");

                    b.Property<int>("DeleteFlag");

                    b.Property<string>("DeptCode");

                    b.Property<int>("DeptLevel");

                    b.Property<string>("DeptName");

                    b.Property<int>("DepteType");

                    b.Property<int>("ParentId");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("BASE_DEPARTMENT");
                });

            modelBuilder.Entity("Com.App.Model.Base.BaseSampPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CheckDate");

                    b.Property<string>("CheckMan");

                    b.Property<int>("DeleteFlag");

                    b.Property<string>("Memo");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<string>("SampPointCode");

                    b.Property<string>("SampPointName");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.HasKey("Id");

                    b.ToTable("BASE_SAMPPOINT");
                });

            modelBuilder.Entity("Com.App.Model.Base.BaseWaterType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CheckDate");

                    b.Property<string>("CheckMan");

                    b.Property<int>("DeleteFlag");

                    b.Property<string>("Memo");

                    b.Property<int>("ParentId");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<int>("TypeId");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.Property<string>("WaterTypeName");

                    b.Property<int>("WaterTypeOrder");

                    b.HasKey("Id");

                    b.ToTable("BASE_WATERTYPE");
                });

            modelBuilder.Entity("Com.App.Model.Sys.SysDictionary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeleteFlag");

                    b.Property<string>("DicCode");

                    b.Property<string>("DicMemo");

                    b.Property<string>("DicName");

                    b.Property<int>("DicOrder");

                    b.Property<string>("DicType");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.HasKey("Id");

                    b.ToTable("SYS_DICTIONARY");
                });

            modelBuilder.Entity("Com.App.Model.Sys.SysMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeleteFlag");

                    b.Property<string>("Img");

                    b.Property<int>("IsOperate");

                    b.Property<int>("IsShow");

                    b.Property<string>("Memo");

                    b.Property<string>("MenuCode");

                    b.Property<string>("MenuName");

                    b.Property<int>("MenuOrder");

                    b.Property<int>("ParentId");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<string>("Target");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("SYS_MENU");
                });

            modelBuilder.Entity("Com.App.Model.Sys.SysRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeleteFlag");

                    b.Property<string>("Memo");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<int>("RoleName");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.HasKey("Id");

                    b.ToTable("SYS_ROLE");
                });

            modelBuilder.Entity("Com.App.Model.Sys.SysRoleMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MenuId");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<int>("RoleId");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.HasKey("Id");

                    b.ToTable("SYS_ROLEMENU");
                });

            modelBuilder.Entity("Com.App.Model.Sys.SysUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeleteFlag");

                    b.Property<int>("DeptId");

                    b.Property<string>("Memo");

                    b.Property<string>("Password");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UserNo")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("SYS_USER");
                });

            modelBuilder.Entity("Com.App.Model.Sys.SysUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeleteFlag");

                    b.Property<string>("Memo");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<int>("RoleId");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("SYS_USERROLE");
                });

            modelBuilder.Entity("Com.App.Model.Task.SamplingPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CheckDate");

                    b.Property<string>("CheckMan");

                    b.Property<int>("DeptId");

                    b.Property<string>("Memo");

                    b.Property<DateTime>("PlanDate");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<int>("Status");

                    b.Property<string>("TaskFrom");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.HasKey("Id");

                    b.ToTable("TASK_SAMPLINPLAN");
                });

            modelBuilder.Entity("Com.App.Model.Task.SamplingPlanDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BackTime");

                    b.Property<string>("Equipment");

                    b.Property<string>("GroupName");

                    b.Property<DateTime>("LeaveTime");

                    b.Property<string>("Memo");

                    b.Property<int>("PointId");

                    b.Property<int>("SampId");

                    b.Property<string>("SamplingMan");

                    b.Property<string>("Vehicle");

                    b.HasKey("Id");

                    b.ToTable("TASK_SAMPLINPLAN_DETAIL");
                });

            modelBuilder.Entity("Com.App.Model.Task.TaskTestPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BegDate");

                    b.Property<DateTime?>("CheckDate");

                    b.Property<string>("CheckMan");

                    b.Property<int>("DeptId");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Memo");

                    b.Property<string>("Participants");

                    b.Property<string>("QualityControleIn");

                    b.Property<string>("QualityControleOut");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<string>("ResultsForm");

                    b.Property<int>("Status");

                    b.Property<string>("TaskCode");

                    b.Property<string>("TaskName");

                    b.Property<string>("TechnicalLeader");

                    b.Property<string>("TestBasis");

                    b.Property<string>("TestObjective");

                    b.Property<string>("TestRange");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.HasKey("Id");

                    b.ToTable("TASK_TESTPLAN");
                });

            modelBuilder.Entity("Com.App.Model.Task.TestTaskNotice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CheckDate");

                    b.Property<string>("CheckMan");

                    b.Property<int>("DeptId");

                    b.Property<string>("Memo");

                    b.Property<DateTime?>("RecordDate");

                    b.Property<string>("RecordMan");

                    b.Property<DateTime>("SampDate");

                    b.Property<DateTime>("SampleTypeId");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdateMan");

                    b.HasKey("Id");

                    b.ToTable("TASK_TESTNOTICE");
                });

            modelBuilder.Entity("Com.App.Model.Task.TestTaskNoticeDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnalysisMethod");

                    b.Property<string>("Memo");

                    b.Property<int>("PointId");

                    b.Property<string>("TestFinishTime");

                    b.Property<string>("TestMan");

                    b.Property<string>("TestProject");

                    b.Property<int>("TestSampleNum");

                    b.Property<int>("TestTaskId");

                    b.HasKey("Id");

                    b.ToTable("TASK_TESTNOTICE_DETAIL");
                });

            modelBuilder.Entity("Com.App.Model.Base.BaseDeparment", b =>
                {
                    b.HasOne("Com.App.Model.Base.BaseCompany", "BaseCompany")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.App.Model.Sys.SysUser", b =>
                {
                    b.HasOne("Com.App.Model.Base.BaseDeparment", "BaseDeparment")
                        .WithMany()
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
