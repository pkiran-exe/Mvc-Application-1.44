using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace PracticeSec4.Models
{
    [Table("StTable")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public int ClassId { get; set; }
        public virtual ICollection<Classes> Classes { get; set; }
        public virtual ICollection<Subject> Subject { get; set; }
    }
}