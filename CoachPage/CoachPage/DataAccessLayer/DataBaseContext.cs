using CoachPage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoachPage.DataAccessLayer
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext()
            : base("name=DbConnectionString")
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Protege> Proteges { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

    }
}