using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Webglobic.Models;

namespace Webglobic.Services
{
        public class StorageBroker : DbContext
        {
            public StorageBroker(DbContextOptions<StorageBroker> options)
            : base(options) => this.Database.Migrate();

            public DbSet<Country> Country { get; set; }
        public DbSet<NavigationMenu> NavigationMenu { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<UserRoleDetails> UserRoleDetails { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Tester> testers { get; set; }
        public DbSet<Location> locations { get; set; }
        public DbSet<ObjectBuilding> objects { get; set; }

        public DbSet<Owner> owner { get; set; }
        public DbSet<TestingOffice> testingOffices { get; set; }
        public DbSet<TestObjectSystem> testObjects { get; set; }
        public DbSet<UserCertification> userCertifications { get; set; }
    
        
    }
}
