using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class AssignedExamMap:CoreMap<AssignedExam>
    {

        public AssignedExamMap()
        {
            // Table property settings

            ToTable("dbo.AssignedExams");
            Property(x => x.IdentificationNumber).HasMaxLength(100).IsRequired();

            // Table relations

            // AppUser Table Relation

            HasRequired(x => x.AppUser)
                .WithMany(x => x.AssignedExams)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);

            // Course Table Relation

            HasRequired(x => x.Exam)
                .WithMany(x => x.AssignedExams)
                .HasForeignKey(x => x.ExamID)
                .WillCascadeOnDelete(false);

            // ExamSession Table Relation

            HasRequired(x => x.ExamSession)
                .WithMany(x => x.AssignedExams)
                .HasForeignKey(x => x.ExamID)
                .WillCascadeOnDelete(false);

        }

    }
}
