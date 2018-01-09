namespace Attendance.Migrations.AttendanceMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigrationAttendanceContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendance",
                c => new
                    {
                        AttendanceId = c.Int(nullable: false, identity: true),
                        ModuleId = c.Int(nullable: false),
                        CollegeId = c.String(maxLength: 128),
                        AttendanceDateTime = c.DateTime(nullable: false),
                        Present = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AttendanceId)
                .ForeignKey("dbo.Module", t => t.ModuleId, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.CollegeId)
                .Index(t => t.ModuleId)
                .Index(t => t.CollegeId);
            
            CreateTable(
                "dbo.Module",
                c => new
                    {
                        ModuleId = c.Int(nullable: false, identity: true),
                        ModuleName = c.String(),
                    })
                .PrimaryKey(t => t.ModuleId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        CollegeId = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.CollegeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendance", "CollegeId", "dbo.Student");
            DropForeignKey("dbo.Attendance", "ModuleId", "dbo.Module");
            DropIndex("dbo.Attendance", new[] { "CollegeId" });
            DropIndex("dbo.Attendance", new[] { "ModuleId" });
            DropTable("dbo.Student");
            DropTable("dbo.Module");
            DropTable("dbo.Attendance");
        }
    }
}
