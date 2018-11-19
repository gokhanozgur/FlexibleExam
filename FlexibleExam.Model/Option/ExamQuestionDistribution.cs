using FlexibleExam.Core.Entity;
using FlexibleExam.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public class ExamQuestionDistribution:CoreEntity
    {
        public Guid CourseUnitOrSubjectID { get; set; }

        public short NumberOfQuestion { get; set; }

        public Semester Semester { get; set; }

        public Guid ExamID { get; set; }        

        public virtual Exam Exam { get; set; }

        public virtual CourseUnitOrSubject CourseUnitOrSubject { get; set; }

    }
}
