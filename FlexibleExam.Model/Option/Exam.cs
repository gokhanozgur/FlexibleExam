using FlexibleExam.Core.Entity;
using FlexibleExam.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    
    public class Exam:CoreEntity
    {
        public Guid CourseID { get; set; }

        public Semester Semester { get; set; }

        public ExamType ExamType { get; set; }

        public TimeSpan Time { get; set; }

        public short NumberOfTotalQuestion { get; set; }

        public virtual Course Course { get; set; }

        public virtual List<AssignedExam> AssignedExams { get; set; }

        public virtual List<ExamAnswerMarking> ExamAnswerMarkings { get; set; }

        public virtual List<ExamQuestionDistribution> ExamQuestionDistributions { get; set; }

        public virtual List<ExamResult> ExamResults { get; set; }

        public virtual List<ExamSession> ExamSessions { get; set; }

    }
}
