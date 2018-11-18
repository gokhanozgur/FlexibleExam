using FlexibleExam.Core.Entity;
using FlexibleExam.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public class AssignedCourse:CoreEntity
    {
        public Semester Semester { get; set; }

        public Guid AppUserID { get; set; }

        public Guid CourseID { get; set; }        

    }
}
