using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Danske_TaxCalucationAPI.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<ManageRuleDTO> ManageRuleDTO { get; set; }
        public DbSet<PeriodDetailsDTO> PeriodDetailsDTO { get; set; }
        public DbSet<MunicipalityDTO> MunicipalityDTO { get; set; }
        public virtual  DbSet<CommonModel> CommonModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Necessary, since our model isnt a EF model
            modelBuilder.Entity<CommonModel>(entity =>
            {
                entity.HasNoKey();
            });
        }
    }
}

