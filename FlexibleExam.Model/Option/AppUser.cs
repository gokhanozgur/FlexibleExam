using FlexibleExam.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public enum Role
    {
        [Display(Name = "Belirtilmiyor")]
        None = 0,
        [Display(Name = "Yönetici")]
        Administrator = 1,
        [Display(Name = "Öğrenci")]
        Student = 2,
        [Display(Name = "Öğretim Görevlisi")]
        Lecturer = 3,
        [Display(Name = "Koordinatör")]
        Coordinator = 4,
        [Display(Name = "Yönetici")]
        Manager = 5
    }

    public class AppUser:CoreEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string IdentificationNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string UserImage { get; set; }
        public string XSmallUserImage { get; set; }
        public string CruptedUserImage { get; set; }

        public Role Role { get; set; }

        public virtual List<AssignedCourse> AssignedCourses { get; set; }

        public virtual List<AssignedExam> AssignedExams { get; set; }

        public virtual List<ExamAnswerMarking> ExamAnswerMarkings { get; set; }

        public virtual List<ExamResult> ExamResults { get; set; }

    }
}
