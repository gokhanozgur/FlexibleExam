using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class ExamMap:CoreMap<Exam>
    {

        public ExamMap()
        {
            // Table property settings

            ToTable("dbo.Exams");
            Property(x => x.Semester).IsRequired();
            Property(x => x.ExamType).IsRequired();
            Property(x => x.Time).IsRequired();

            // Table relations

            // Course Table Relation

            HasRequired(x => x.Course)
                .WithMany(x => x.Exams)
                .HasForeignKey(x => x.CourseID)
                .WillCascadeOnDelete(false);

            // AssignedExams Table Relation

            HasMany(x => x.AssignedExams)
                .WithRequired(x => x.Exam)
                .HasForeignKey(x => x.ExamID)
                .WillCascadeOnDelete(false);
        }
    }
}
