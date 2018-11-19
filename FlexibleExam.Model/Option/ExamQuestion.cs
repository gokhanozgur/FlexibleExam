using FlexibleExam.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public enum Difficulty
    {
        [Display(Name = "Belirtilmiyor")]
        None = 0,
        [Display(Name = "Çok Kolay")]
        Very_Easy = 1,
        [Display(Name = "Kolay")]
        Easy = 2,
        [Display(Name = "Orta")]
        Medium = 3,
        [Display(Name = "Zor")]
        Hard = 4,
        [Display(Name = "Çok Zor")]
        Very_Hard = 5,

    }

    public class ExamQuestion:CoreEntity
    {
        public Guid CourseID { get; set; }

        public Guid CourseUnitOrSubjectID { get; set; }

        public string Question { get; set; }

        public short Unit { get; set; }

        public Difficulty Difficulty { get; set; }        

        public virtual Course Course { get; set; }

        public virtual CourseUnitOrSubject CourseUnitOrSubject { get; set; }

        public virtual List<ExamAnswerMarking> ExamAnswerMarkings { get; set; }

        public virtual List<ExamQuestionAnswerOption> ExamQuestionAnswerOptions { get; set; }

    }
}
