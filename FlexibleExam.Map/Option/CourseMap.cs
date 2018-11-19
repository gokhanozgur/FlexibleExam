using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class CourseMap:CoreMap<Course>
    {

        public CourseMap()
        {
            // Table property settings

            ToTable("dbo.Courses");
            Property(x => x.CourseName).HasMaxLength(100).IsRequired();
            Property(x => x.CourseShortName).HasMaxLength(20).IsRequired();
            Property(x => x.Semester);

            // Table relations

            // AssignedCourses Table Relation

            HasMany(x => x.AssignedCourses)
                .WithRequired(x => x.Course)
                .HasForeignKey(x => x.CourseID)
                .WillCascadeOnDelete(false);
        }

    }
}
