using Microsoft.EntityFrameworkCore;

namespace Task4_19101001033.Models
{
    public class SignupDbContext:DbContext
    {

        public SignupDbContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Signup> Signup { get; set; }

    }
}
