using FlexibleExam.Core.Entity;
using FlexibleExam.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public class ExamAnswerMarking:CoreEntity
    {       

        public Guid ExamID { get; set; }

        public Guid ExamQuestionID { get; set; }

        public Guid AnswerOptionID { get; set; }

        public Guid AppUserID { get; set; }

        public Semester Semester { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual ExamQuestion ExamQuestion { get; set; }

        public virtual ExamQuestionAnswerOption ExamQuestionAnswerOption { get; set; }

        public virtual AppUser AppUser { get; set; }



    }
}
