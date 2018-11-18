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
        Fall_Semester = 1,
        [Display(Name = "Bahar")]
        Spring_Term = 2,
        [Display(Name = "Yaz")]
        Summer_School = 3,
    }
}
