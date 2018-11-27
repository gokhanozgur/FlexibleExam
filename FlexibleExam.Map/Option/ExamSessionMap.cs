using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class ExamSessionMap:CoreMap<ExamSession>
    {

        public ExamSessionMap()
        {
            // Table property settings

            ToTable("dbo.ExamSessions");
            Property(x => x.SessionNo).HasMaxLength(20).IsRequired();
            Property(x => x.DateTimeOfStart).IsRequired();
            Property(x => x.DateTimeOfFinish).IsRequired();
            Property(x => x.Semester).IsRequired();

            // Table relations

            // Exam Table Relation

            HasRequired(x => x.Exam)
                .WithMany(x => x.ExamSessions)
                .HasForeignKey(x => x.ExamID)
                .WillCascadeOnDelete(false);
                

            // LocationRoom Table Relation

            HasRequired(x => x.LocationRoom)
                .WithMany(x => x.ExamSessions)
                .HasForeignKey(x => x.LocationRoomID)
                .WillCascadeOnDelete(false);
        }

    }
}
