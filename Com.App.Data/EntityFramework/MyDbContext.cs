using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.App.Model;
using Microsoft.EntityFrameworkCore;

namespace Com.App.Data.EntityFramework
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Model.Sys.SysUser> SysUser { get; set; }  
        public DbSet<Model.Sys.SysMenu> SysMenu { get; set; }
        public DbSet<Model.Sys.SysRole> SysRole { get; set; }
        public DbSet<Model.Sys.SysUserRole> SysUserRole { get; set; }
        public DbSet<Model.Sys.SysRoleMenu> SysRoleMenu { get; set; }
        public DbSet<Model.Sys.SysDictionary> SysDictionary { get; set; }
        /****************************************************************/
        public DbSet<Model.Base.BaseDeparment> BaseDeparment { get; set; }
        public DbSet<Model.Base.BaseCompany> BaseCompany { get; set; } 
        public DbSet<Model.Base.BaseSampPoint> BaseSampPoint { get; set; }
        public DbSet<Model.Base.BaseWaterType> BaseWaterType { get; set; }
        /****************************************************************/
        public DbSet<Model.Task.SamplingPlan> SamplingPlan { get; set; }
        public DbSet<Model.Task.SamplingPlanDetail> SamplingPlanDetail { get; set; }
        public DbSet<Model.Task.TaskTestPlan> TaskTestPlan { get; set; }
        public DbSet<Model.Task.TestTaskNotice> TestTaskNotice { get; set; }
        public DbSet<Model.Task.TestTaskNoticeDetail> TestTaskNoticeDetail { get; set; }
   



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Model.Base.BaseDeparment>().ToTable("BASE_DEPARTMENT");
            modelBuilder.Entity<Model.Base.BaseCompany>().ToTable("BASE_COMPANY");
            modelBuilder.Entity<Model.Sys.SysUser>().ToTable("SYS_USER");
            modelBuilder.Entity<Model.Sys.SysMenu>().ToTable("SYS_MENU");
            modelBuilder.Entity<Model.Sys.SysRole>().ToTable("SYS_ROLE");
            modelBuilder.Entity<Model.Sys.SysRoleMenu>().ToTable("SYS_ROLEMENU");
            modelBuilder.Entity<Model.Sys.SysUserRole>().ToTable("SYS_USERROLE");
        }
    }
}