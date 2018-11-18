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

        public short CorrectAnswerCount { get; set; }

        public short WrongAnswerCount { get; set; }

        public short UnAnsweredCount { get; set; }

        public short ExamScore { get; set; }

        public Semester Semester { get; set; }

    }
}
