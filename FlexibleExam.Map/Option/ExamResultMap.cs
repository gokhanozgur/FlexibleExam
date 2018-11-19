using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class ExamResultMap:CoreMap<ExamResult>
    {

        public ExamResultMap()
        {
            // Table property settings

            ToTable("dbo.ExamResults");
            Property(x => x.IdentificationNumber).IsRequired();
            Property(x => x.CorrectAnswerCount).IsRequired();
            Property(x => x.WrongAnswerCount).IsRequired();
            Property(x => x.UnAnsweredCount).IsRequired();
            Property(x => x.ExamScore).IsRequired();
            Property(x => x.ExamScore).IsRequired();
            Property(x => x.Semester).IsRequired();

            // Table relations

            // Exam Table Relation

            HasRequired(x => x.Exam)
                .WithMany(x => x.ExamResults)
                .HasForeignKey(x => x.ExamID)
                .WillCascadeOnDelete(false);

            // AppUser Table Relation

            HasRequired(x => x.AppUser)
                .WithMany(x => x.ExamResults)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);

            // Course Table Relation

            HasRequired(x => x.Course)
                .WithMany(x => x.ExamResults)
                .HasForeignKey(x => x.CourseID)
                .WillCascadeOnDelete(false);

        }

    }
}
