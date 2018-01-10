namespace Attendance.Migrations.AttendanceMigrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.AttendanceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"AttendanceMigrations";
        }

        protected override void Seed(Models.AttendanceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            // SeedStudents(context);
            SeedModules(context);
        }
        //seeding students
        private void SeedStudents(AttendanceContext context)
          {
                context.Students.AddOrUpdate(u => u.CollegeId, new Student
              {
                  CollegeId = "S00000001",
                  FirstName = "John",
                  LastName = "Tooth"
              });

            context.Students.AddOrUpdate(u => u.CollegeId, new Student
            {
                CollegeId = "S00000002",
                FirstName = "Mary",
                LastName = "Lee"
            });

            context.Students.AddOrUpdate(u => u.CollegeId, new Student
            {
                CollegeId = "S00000003",
                FirstName = "Christopher",
                LastName = "Smoth"
            });
        }

        //seed modules
        private void SeedModules(AttendanceContext context)
        {
            context.Modules.AddOrUpdate(u => u.ModuleId, new Module
            {
                ModuleId = 1,
                ModuleName = "RAD"
            });

            context.Modules.AddOrUpdate(u => u.ModuleId, new Module
            {
                ModuleId = 2,
                ModuleName = "Database"
            });

            context.Modules.AddOrUpdate(u => u.ModuleId, new Module
            {
                ModuleId = 3,
                ModuleName = "Web"
            });
        }

    }
}
