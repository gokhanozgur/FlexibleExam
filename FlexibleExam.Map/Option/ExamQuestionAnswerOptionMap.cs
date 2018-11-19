using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class ExamQuestionAnswerOptionMap:CoreMap<ExamQuestionAnswerOption>
    {

        public ExamQuestionAnswerOptionMap()
        {
            // Table property settings

            ToTable("dbo.ExamQuestionAnswerOptions");
            Property(x => x.AnswerOption).IsRequired();
            //Property(x => x.OptionLetter).IsRequired();

            // Table relations

            // ExamQuestion Table Relation

            HasRequired(x => x.ExamQuestion)
                .WithMany(x => x.ExamQuestionAnswerOptions)
                .HasForeignKey(x => x.ExamQuestionID)
                .WillCascadeOnDelete(false);

            // ExamAnswerMarkings Table Relation

            HasMany(x => x.ExamAnswerMarkings)
                .WithRequired(x => x.ExamQuestionAnswerOption)
                .HasForeignKey(x => x.AnswerOptionID)
                .WillCascadeOnDelete(false);

        }

    }
}
