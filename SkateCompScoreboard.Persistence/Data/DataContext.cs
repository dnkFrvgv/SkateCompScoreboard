using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SkateCompScoreboard.Persistence.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions opt) : base(opt) { }

        public DbSet<Competition> Competitions {get;set;}
        public DbSet<Round> Rounds { get;set;}
        public DbSet<Competitor> Competitors { get;set;}
        public DbSet<RoundCompetitor> RoundCompetitors { get;set;}
        public DbSet<Trick> Tricks { get;set;}
        public DbSet<Score> Scores { get; set; }
        public DbSet<Address> Addresses { get;set;}
        public DbSet<LineSection> LineSections { get; set; }
        public DbSet<SingleTrickSection> SingleTrickSections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Section>().UseTpcMappingStrategy();

            modelBuilder.Entity<RoundCompetitor>(x => x.HasKey(rc => new { rc.RoundId, rc.CompetitorId }));

            modelBuilder.Entity<RoundCompetitor>()
                .HasOne(x => x.Round)
                .WithMany(x => x.Competitors)
                .HasForeignKey(x => x.RoundId);

            modelBuilder.Entity<RoundCompetitor>()
                .HasOne(x => x.Competitor)
                .WithMany(x => x.Rounds)
                .HasForeignKey(x => x.CompetitorId);


            modelBuilder.ApplyConfiguration(new CompetitionConfiguration());
        }
    }
}
