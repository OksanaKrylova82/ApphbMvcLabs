using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ApphbMvcLabs.Data.Entities;

namespace ApphbMvcLabs.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DataContext")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}