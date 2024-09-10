using System.ComponentModel.DataAnnotations;

namespace IUR.Service
{
    public class UserDTO
    {
        public string? Id { get; set; }

        [Required(ErrorMessage = "'name' is required to complete your request")]
        [StringLength(30, ErrorMessage = "The maximum length is {1} characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "'email' is required to complete your request")]
        [StringLength(30, ErrorMessage = "The maximum length is {1} characters")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "'last name' is required to complete your request")]
        [StringLength(30, ErrorMessage = "The maximum length is {1} characters")]
        public string? Lastname { get; set; }

        [Required(ErrorMessage = "'password' is required to complete your request")]
        public string? Password { get; set; }
    }
}
