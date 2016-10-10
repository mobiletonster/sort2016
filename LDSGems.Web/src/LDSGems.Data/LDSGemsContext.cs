using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using LDSGems.Models;

namespace LDSGems.Data
{
    public partial class LDSGemsContext : DbContext
    {
        public LDSGemsContext(DbContextOptions<LDSGemsContext> options)
            : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder not needed if we are passing in options above.
            // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            // optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\spencerto\Source\Repos\sort2016\LDSGems.Web\src\LDSGems.Web\App_Data\glfeed.mdf;Integrated Security=True;Connect Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DailyGems>(entity =>
            {
                entity.HasIndex(e => new { e.Guid, e.LangCode })
                    .HasName("IX_DailyGems");

                entity.Property(e => e.Author).HasColumnType("varchar(250)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnType("varchar(250)");

                entity.Property(e => e.LangCode).HasColumnType("varchar(10)");

                entity.Property(e => e.LdsOrgUrl).HasColumnType("varchar(1000)");

                entity.Property(e => e.Link).HasColumnType("varchar(500)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PubDate).HasColumnType("datetime");

                entity.Property(e => e.Quote).HasColumnType("varchar(max)");

                entity.Property(e => e.RawDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.SourceRss).HasColumnType("varchar(1000)");

                entity.Property(e => e.Title).HasColumnType("varchar(500)");

                entity.Property(e => e.Topic).HasColumnType("varchar(1000)");
            });
        }

        public virtual DbSet<DailyGems> DailyGems { get; set; }
    }
}