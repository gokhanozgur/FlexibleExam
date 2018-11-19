using FlexibleExam.Core.Entity;
using FlexibleExam.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public class ExamResult:CoreEntity
    {
        public Guid ExamID { get; set; }

        public Guid AppUserID { get; set; }

        public Guid CourseID { get; set; }

        public string IdentificationNumber { get; set; }

        public short CorrectAnswerCount { get; set; }

        public short WrongAnswerCount { get; set; }

        public short UnAnsweredCount { get; set; }

        public short ExamScore { get; set; }

        public Semester Semester { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual Course Course { get; set; }

    }
}
