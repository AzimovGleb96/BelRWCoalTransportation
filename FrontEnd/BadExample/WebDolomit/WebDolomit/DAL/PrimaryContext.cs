using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebDolomit.Models;

namespace WebDolomit.DAL
{
    public class PrimaryContext : DbContext
    {       
        public DbSet<Data> DataOnWagons { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}