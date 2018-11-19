using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class ExamQuestionMap:CoreMap<ExamQuestion>
    {

        public ExamQuestionMap()
        {
            // Table property settings

            ToTable("dbo.ExamQuestions");
            Property(x => x.Question).IsRequired();
            Property(x => x.Unit).IsRequired();
            Property(x => x.Difficulty).IsRequired();

            // Table relations

            // Course Table Relation

            HasRequired(x => x.Course)
                .WithMany(x => x.ExamQuestions)
                .HasForeignKey(x => x.CourseID)
                .WillCascadeOnDelete(false);

            // Course Table Relation

            HasRequired(x => x.CourseUnitOrSubject)
                .WithMany(x => x.ExamQuestions)
                .HasForeignKey(x => x.CourseUnitOrSubjectID)
                .WillCascadeOnDelete(false);

            // ExamAnswerMarkings Table Relation

            HasMany(x => x.ExamAnswerMarkings)
                .WithRequired(x => x.ExamQuestion)
                .HasForeignKey(x => x.ExamQuestionID)
                .WillCascadeOnDelete(false);

        }

    }
}
