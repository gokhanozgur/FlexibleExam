using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Core.Enum
{
    public enum Semester
    {
        [Display(Name = "Belirtilmiyor")]
        None = 0,
        [Display(Name = "Güz")]
        FallSemester = 1,
        [Display(Name = "Bahar")]
        SpringTerm = 2,
        [Display(Name = "Yaz")]
        SummerSchool = 3,
    }
}
