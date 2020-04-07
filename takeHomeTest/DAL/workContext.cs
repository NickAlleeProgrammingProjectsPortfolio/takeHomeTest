using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using takeHomeTest.Models;

namespace takeHomeTest.DAL
{
    public class workContext: DbContext
    {
        

            public workContext() : base("workContext")
            {
            }

            public DbSet<phoneData> phoneData { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
    }
}
