using FlexibleExam.Core.Entity;
using FlexibleExam.Core.Enum;
using FlexibleExam.Map.Option;
using FlexibleExam.Model.Option;
using FlexibleExam.Utility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.DAL.Context
{
    public class ProjectContext : DbContext
    {

        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=FlexibleExam;uid=sa;pwd=123";

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AssignedCourseMap());
            modelBuilder.Configurations.Add(new AssignedExamMap());
            modelBuilder.Configurations.Add(new CourseMap());
            modelBuilder.Configurations.Add(new CourseUnitOrSubjectMap());
            modelBuilder.Configurations.Add(new ExamAnswerMarkingMap());
            modelBuilder.Configurations.Add(new ExamMap());
            modelBuilder.Configurations.Add(new ExamQuestionAnswerOptionMap());
            modelBuilder.Configurations.Add(new ExamQuestionDistributionMap());
            modelBuilder.Configurations.Add(new ExamQuestionMap());
            modelBuilder.Configurations.Add(new ExamResultMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new LocationRoomMap());
            modelBuilder.Configurations.Add(new ExamSessionMap());
            modelBuilder.Configurations.Add(new AssignedSessionStaffMap());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<AssignedCourse> AssignedCourses { get; set; }

        public DbSet<AssignedExam> AssignedExams { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<CourseUnitOrSubject> CourseUnitOrSubjects { get; set; }

        public DbSet<Exam> Exams { get; set; }

        public DbSet<ExamAnswerMarking> ExamAnswerMarkings { get; set; }

        public DbSet<ExamQuestion> ExamQuestions { get; set; }

        public DbSet<ExamQuestionAnswerOption> ExamQuestionAnswerOptions { get; set; }

        public DbSet<ExamQuestionDistribution> ExamQuestionDistributions { get; set; }

        public DbSet<ExamResult> ExamResults { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<LocationRoom> LocationRooms { get; set; }

        public DbSet<ExamSession> ExamSessions { get; set; }

        public DbSet<AssignedSessionStaff> AssignedSessionStaffs { get; set; }


        public override int SaveChanges()
        {

            var modifiedEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);

            string identity = WindowsIdentity.GetCurrent().Name;
            string computerName = Environment.MachineName;
            DateTime dateTime = DateTime.Now;
            string getIp = RemoteIP.IpAddress;


            foreach (var item in modifiedEntries)
            {
                CoreEntity entity = item.Entity as CoreEntity;

                if (item != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        entity.Status = Status.Active;
                        entity.CreatedUserName = identity;
                        entity.CreatedComputerName = computerName;
                        entity.CreatedDate = dateTime;
                        entity.CreatedIP = getIp;
                    }
                    else if (item.State == EntityState.Modified)
                    {
                        //entity.Status = Status.Updated;
                        entity.ModifiedUserName = identity;
                        entity.ModifiedComputerName = computerName;
                        entity.ModifiedDate = dateTime;
                        entity.ModifiedIP = getIp;
                    }

                }
            }


            return base.SaveChanges();
        }

    }
}
