using Microsoft.EntityFrameworkCore;
using NotBoosty.Models;

namespace NotBoosty.Data
{
    public class UserDataContext : DbContext
    {
        public UserDataContext(DbContextOptions<UserDataContext> options) : base(options) { }

        public DbSet<UserData> UserData { get; set; } = default!;
        public DbSet<UserTg>? UserTg { get; set; }


    }
}
