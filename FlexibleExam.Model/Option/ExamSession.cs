using FlexibleExam.Core.Entity;
using FlexibleExam.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public class ExamSession:CoreEntity
    {

        public Guid ExamID { get; set; }
        
        public Guid LocationRoomID { get; set; }

        public string SessionNo { get; set; }

        public DateTime DateTimeOfStart { get; set; }

        public DateTime DateTimeOfFinish { get; set; }

        public Semester Semester { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual LocationRoom LocationRoom { get; set; }

        public virtual List<AssignedExam> AssignedExams { get; set; }
    }
}
