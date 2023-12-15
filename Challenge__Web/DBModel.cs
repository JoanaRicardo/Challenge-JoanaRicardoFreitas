using Challenge__Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;

namespace Challenge__Web {
    public class DBModel: DbContext {
        public DBModel() {
        }

        public DBModel(DbContextOptions<DBModel> options) : base(options) {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        }

        public override int SaveChanges() {
            this.ChangeTracker.DetectChanges();
            return base.SaveChanges();

        }
        
    }
}