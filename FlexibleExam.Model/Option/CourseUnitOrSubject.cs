using FlexibleExam.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public class CourseUnitOrSubject:CoreEntity
    {
        public Guid CourseID { get; set; }

        public string UnitOrSubject { get; set; }

        public short UnitNumber { get; set; }

        public string Description { get; set; }        

        public virtual Course Course { get; set; }

        public virtual List<ExamQuestion> ExamQuestions { get; set; }

        public virtual List<ExamQuestionDistribution> ExamQuestionDistributions { get; set; }
    }
}
