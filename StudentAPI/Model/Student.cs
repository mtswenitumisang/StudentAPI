using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Model
{
    public class Student
    {
        [Key]
        public int? StudentId { get; set; }
        public string? StudentName { get; set; }
        public int? StudentAge { get; set; }
        public string? StudentEmail { get; set; }
    }
}