using System.ComponentModel.DataAnnotations;

namespace Task4_19101001033.Models
{
    public class Signup
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

    }
}
