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

        public string LessonName { get; set; }

        public string LessonShortName { get; set; }

        public Semester Semester { get; set; }

    }
}
