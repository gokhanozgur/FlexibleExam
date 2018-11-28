using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class AssignedSessionStaffMap:CoreMap<AssignedSessionStaff>
    {

        public AssignedSessionStaffMap()
        {

            // Table property settings

            ToTable("dbo.AssignedSessionStaffs");
            Property(x => x.Status).IsRequired();
            Property(x => x.TaskStatus).IsRequired();

            // Table relations

            // AppUser Table Relation

            HasRequired(x => x.AppUser)
                    .WithMany(x => x.AssignedSessionStaffs)
                    .HasForeignKey(x => x.AppUserID)
                    .WillCascadeOnDelete(false);

            // ExamSession Table Relation

            HasRequired(x => x.ExamSession)
                    .WithMany(x => x.AssignedSessionStaffs)
                    .HasForeignKey(x => x.ExamSessionID)
                    .WillCascadeOnDelete(false);

        }

    }
}
