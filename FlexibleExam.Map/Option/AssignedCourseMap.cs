using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class AssignedCourseMap:CoreMap<AssignedCourse>
    {

        public AssignedCourseMap()
        {

            // Table property settings

            ToTable("dbo.AssignedCourses");
            Property(x => x.Semester);

            // Table relations

            // AppUser Table Relation

            HasRequired(x => x.AppUser)
                .WithMany(x => x.AssignedCourses)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);

            // Course Table Relation

            HasRequired(x => x.Course)
                .WithMany(x => x.AssignedCourses)
                .HasForeignKey(x => x.CourseID)
                .WillCascadeOnDelete(false);

        }

    }
}
