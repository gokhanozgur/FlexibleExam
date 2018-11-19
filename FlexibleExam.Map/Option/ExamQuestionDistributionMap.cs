using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class ExamQuestionDistributionMap:CoreMap<ExamQuestionDistribution>
    {

        public ExamQuestionDistributionMap()
        {
            // Table property settings

            ToTable("dbo.ExamQuestionDistributions");
            Property(x => x.NumberOfQuestion).IsRequired();
            Property(x => x.Semester).IsRequired();

            // Table relations

            // Exam Table Relation

            HasRequired(x => x.Exam)
                .WithMany(x => x.ExamQuestionDistributions)
                .HasForeignKey(x => x.ExamID)
                .WillCascadeOnDelete(false);

            // CourseUnitOrSubject Table Relation

            HasRequired(x => x.CourseUnitOrSubject)
                .WithMany(x => x.ExamQuestionDistributions)
                .HasForeignKey(x => x.CourseUnitOrSubjectID)
                .WillCascadeOnDelete(false);
        }
    }
}
