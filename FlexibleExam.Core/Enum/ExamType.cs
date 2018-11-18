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
        Midterm_Make_Up = 3,
        [Display(Name = "Final")]
        Final = 4,
        [Display(Name = "Bütünleme")]
        Make_Up = 5,
        [Display(Name = "Tek Ders ve Not Yükseltme")]
        Single_Course_Exams = 6,
        [Display(Name = "Seviye Belirleme")]
        Placement_Test = 7,

    }
}
