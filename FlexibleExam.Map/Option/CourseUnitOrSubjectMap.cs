using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class CourseUnitOrSubjectMap:CoreMap<CourseUnitOrSubject>
    {

        public CourseUnitOrSubjectMap()
        {
            // Table property settings

            ToTable("dbo.CourseUnitOrSubjects");
            Property(x => x.UnitOrSubject).HasMaxLength(100).IsRequired();
            Property(x => x.UnitNumber).IsRequired();
            Property(x => x.Description).HasMaxLength(255).IsOptional();

            // Table relations

            // Course Table Relation

            HasRequired(x => x.Course)
                .WithMany(x => x.CourseUnitOrSubjects)
                .HasForeignKey(x => x.CourseID)
                .WillCascadeOnDelete(false);
        }
    }
}
