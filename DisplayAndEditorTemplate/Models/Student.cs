using System;
using System.ComponentModel.DataAnnotations;

namespace DisplayAndEditorTemplate.Models
{
    public class Student
    {
        public int? StudentId { get; set; }
        public string FullName { get; set; }

        //[UIHint("Date")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Is Graduate ???")]
        public bool IsGraduate { get; set; }
    }
}
