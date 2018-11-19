using FlexibleExam.Core.Entity;
using FlexibleExam.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public class Course:CoreEntity
    {

        public string CourseName { get; set; }

        public string CourseShortName { get; set; }

        public Semester Semester { get; set; }

        public virtual List<Exam> Exams { get; set; }

        public virtual List<AssignedCourse> AssignedCourses { get; set; }

        public virtual List<CourseUnitOrSubject> CourseUnitOrSubjects { get; set; }

        public virtual List<ExamQuestion> ExamQuestions { get; set; }

        public virtual List<ExamResult> ExamResults { get; set; }

    }
}
