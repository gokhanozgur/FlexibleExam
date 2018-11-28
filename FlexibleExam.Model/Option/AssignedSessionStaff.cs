using FlexibleExam.Core.Entity;
using FlexibleExam.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public class AssignedSessionStaff : CoreEntity
    {

        public Guid AppUserID { get; set; }

        public Guid ExamSessionID { get; set; }

        public Status Status { get; set; }

        public Core.Enum.TaskStatus TaskStatus { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual ExamSession ExamSession { get; set; }

    }
}
