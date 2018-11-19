using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Core.Enum
{
    public enum ExamStatus
    {

        [Display(Name = "Bilinmiyor")]
        None = 1,

        [Display(Name = "Beklemede")]
        HoldOn = 2,

        [Display(Name = "Sınavda")]
        OnExam = 3,

        [Display(Name = "Tamamlandı")]
        Complated = 4,

        [Display(Name = "İptal Edildi")]
        Cancelled = 5

    }
}
