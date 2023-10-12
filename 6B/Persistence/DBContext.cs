using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNet.Identity.EntityFramework;
using Persistence.Identity;
using Domain.Entities;

namespace Persistence
{
    public class DBContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Booking> Bookings { get; set; }
    }
}
