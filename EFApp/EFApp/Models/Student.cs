using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFApp.Models
{
    [Table("NewStudents")]
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Нельзя оставлять поле пустым")]
        [MaxLength(50,ErrorMessage ="Строка должна иметь длину не более 50 символов")]
        [Display(Name ="Фамилия")]
        public string LastName { get; set; }
        [MaxLength(50)]
        [Display(Name = "Имя")]
        public string FirstMidName { get; set; }
        [Display(Name = "Дата записи на курсы")]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}