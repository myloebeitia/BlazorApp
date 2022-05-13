using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schiavello.Data
{
    public class ListDbContext : DbContext
    {
        #region Contructor
        public ListDbContext(DbContextOptions<ListDbContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public properties
        public DbSet<List> List { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<List>().HasData(GetLists());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        private List<List> GetLists()
        {
            return new List<List>
            {
                new List { Id = 1001, Name = "Test", Status = "Active"},
                new List { Id = 1002, Name = "test2", Status = "Active"},
                new List { Id = 1003, Name = "test3", Status = "Active"},
                new List { Id = 1004, Name = "test4", Status = "Active"},
            };
        }
        #endregion
    }
}
