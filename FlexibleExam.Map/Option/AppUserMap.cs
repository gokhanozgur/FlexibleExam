using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class AppUserMap:CoreMap<AppUser>
    {

        public AppUserMap()
        {
            // Table property settings

            ToTable("dbo.AppUsers");
            Property(x => x.Name).HasMaxLength(50).IsRequired();
            Property(x => x.LastName).HasMaxLength(50).IsRequired();
            Property(x => x.UserName).HasMaxLength(50).IsRequired();
            Property(x => x.IdentificationNumber).HasMaxLength(100).IsRequired();
            Property(x => x.Email).HasMaxLength(100).IsOptional();
            Property(x => x.Password).HasMaxLength(50).IsRequired();
            Property(x => x.PhoneNumber).HasMaxLength(11).IsOptional();
            Property(x => x.Address).HasMaxLength(255).IsOptional();
            Property(x => x.Birthdate).HasColumnType("datetime2").IsOptional();
            Property(x => x.UserImage).HasMaxLength(250).IsOptional();
            Property(x => x.XSmallUserImage).IsOptional();
            Property(x => x.CruptedUserImage).IsOptional();
            Property(x => x.Role);

            // Table relations

            // AssignedCourses Table Relation

            HasMany(x => x.AssignedCourses)
                .WithRequired(x => x.AppUser)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);

            // AssignedExams Table Relation

            HasMany(x => x.AssignedExams)
                .WithRequired(x => x.AppUser)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);

            // ExamAnswerMarkings Table Relation

            HasMany(x => x.ExamAnswerMarkings)
                .WithRequired(x => x.AppUser)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);

            // ExamResults Table Relation

            HasMany(x => x.ExamResults)
                .WithRequired(x => x.AppUser)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);

        }

    }
}
