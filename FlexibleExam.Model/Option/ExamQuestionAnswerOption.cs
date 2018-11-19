using FlexibleExam.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public class ExamQuestionAnswerOption:CoreEntity
    {
        public Guid ExamQuestionID { get; set; }

        public string AnswerOption { get; set; }

        public char OptionLetter { get; set; }        

        public virtual ExamQuestion ExamQuestion { get; set; }

        public virtual List<ExamAnswerMarking> ExamAnswerMarkings { get; set; }

    }
}
