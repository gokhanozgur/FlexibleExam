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

        public Semester Semester { get; set; }

        public ExamType ExamType { get; set; }

        public TimeSpan Time { get; set; }

        public short NumberOfTotalQuestion { get; set; }

        public Guid CourseID { get; set; }

    }
}
