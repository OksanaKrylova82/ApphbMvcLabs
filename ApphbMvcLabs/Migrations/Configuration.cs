using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ApphbMvcLabs.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApphbMvcLabs.Data.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;            
        }        

        protected override void Seed(ApphbMvcLabs.Data.DataContext context)
        {
        }
    }
}
