using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Invitation.Models;

namespace Invitation.Data
{
    public class InvitationContext : DbContext
    {
        public InvitationContext (DbContextOptions<InvitationContext> options)
            : base(options)
        {
        }

        public DbSet<Invitation.Models.Users> Users { get; set; } = default!;
    }
}
