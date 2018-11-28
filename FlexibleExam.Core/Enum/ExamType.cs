using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Core.Enum
{
    public enum ExamType
    {

        [Display(Name = "Belirtilmiyor")]
        None = 0,
        [Display(Name = "Ara Sınav")]
        Midterm = 1,
        [Display(Name = "Ara Sınav Mazeret")]
        MidtermMakeUp = 3,
        [Display(Name = "Final")]
        Final = 4,
        [Display(Name = "Bütünleme")]
        MakeUp = 5,
        [Display(Name = "Tek Ders ve Not Yükseltme")]
        SingleCourseExams = 6,
        [Display(Name = "Seviye Belirleme")]
        PlacementTest = 7,

    }
}
