using Microsoft.EntityFrameworkCore;

namespace Invitation.Models
{
    public class InvitationContext : DbContext
    {
        public InvitationContext(DbContextOptions<InvitationContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
    }
}
