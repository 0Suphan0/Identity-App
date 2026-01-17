using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginApp.Models
{
    public class AppDbContext: IdentityDbContext
    {
            
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
