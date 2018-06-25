﻿// <auto-generated />
using Com.App.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Com.App.Web.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20180224015620_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.App.Model.Base.BaseDeparment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DeleteFlag");

                    b.Property<string>("DeptCode");

                    b.Property<int>("DeptLevel");

                    b.Property<string>("DeptName");

                    b.Property<int>("DepteType");

                    b.Property<int>("ParentId");

                    b.HasKey("Id");

                    b.ToTable("BASE_DEPARTMENT");
                });

            modelBuilder.Entity("Com.App.Model.Sys.SysMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DeleteFlag");

                    b.Property<string>("Memo");

                    b.Property<int>("MenuName");

                    b.HasKey("Id");

                    b.ToTable("SYS_MENU");
                });

            modelBuilder.Entity("Com.App.Model.Sys.SysRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DeleteFlag");

                    b.Property<string>("Memo");

                    b.Property<int>("RoleName");

                    b.HasKey("Id");

                    b.ToTable("SYS_ROLE");
                });

            modelBuilder.Entity("Com.App.Model.Sys.SysUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DeleteFlag");

                    b.Property<int>("DeptId");

                    b.Property<string>("Memo");

                    b.Property<string>("Password");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UserNo");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("SYS_USER");
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