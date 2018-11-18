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

        public string UnitOrSubject { get; set; }

        public short UnitNumber { get; set; }

        public string Description { get; set; }

        public Guid CourseID { get; set; }
    }
}
