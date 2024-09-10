using System.ComponentModel.DataAnnotations;

namespace IUR_Backend.Models.Dto.StudentDto
{
    public class StudentDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public ICollection<StudentCourseDto> Courses { get; set; }

        public ICollection<StudentExamDto> Exams { get; set; }
    }
}
