using FlexibleExam.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model
{
    public enum Role
    {
        [Display(Name = "Belirtilmiyor")]
        None = 0,
        [Display(Name = "Administrator")]
        Administrator = 1,
        [Display(Name = "Student")]
        Student = 2,
        [Display(Name = "Lecturer")]
        Lecturer = 3,
        [Display(Name = "Coordinator")]
        Coordinator = 4,
        [Display(Name = "Manager")]
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

    }
}
