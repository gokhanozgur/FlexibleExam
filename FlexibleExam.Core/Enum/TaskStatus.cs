using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Core.Enum
{
    public enum TaskStatus
    {
        [Display(Name = "Bilinmiyor")]
        None = 0,
        [Display(Name = "Beklemede")]
        Waiting = 1,
        [Display(Name = "Aktif")]
        Active = 2,
        [Display(Name = "İptal Edildi")]
        Canceled = 3,

    }
}
