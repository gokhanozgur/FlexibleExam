using FlexibleExam.Core.Entity;
using FlexibleExam.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public class AssignedExam:CoreEntity
    {

        public string IdentificationNumber { get; set; }

        public Semester Semester { get; set; }

        public Guid ExamID { get; set; }

        public Guid AppUserID { get; set; }

    }
}
