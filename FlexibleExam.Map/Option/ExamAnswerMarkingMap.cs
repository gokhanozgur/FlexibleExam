using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class ExamAnswerMarkingMap:CoreMap<ExamAnswerMarking>
    {

        public ExamAnswerMarkingMap()
        {
            // Table property settings

            ToTable("dbo.ExamAnswerMarkings");
            Property(x => x.Semester).IsRequired();

            // Table relations

            // Course Table Relation

            HasRequired(x => x.Exam)
                .WithMany(x => x.ExamAnswerMarkings)
                .HasForeignKey(x => x.ExamID)
                .WillCascadeOnDelete(false);

            // ExamQuestion Table Relation

            HasRequired(x => x.ExamQuestion)
                .WithMany(x => x.ExamAnswerMarkings)
                .HasForeignKey(x => x.ExamQuestionID)
                .WillCascadeOnDelete(false);

            // ExamQuestionAnswerOption Table Relation

            HasRequired(x => x.ExamQuestionAnswerOption)
                .WithMany(x => x.ExamAnswerMarkings)
                .HasForeignKey(x => x.AnswerOptionID)
                .WillCascadeOnDelete(false);

            // AppUser Table Relation

            HasRequired(x => x.AppUser)
                .WithMany(x => x.ExamAnswerMarkings)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);

        }

    }
}
