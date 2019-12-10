using Microsoft.EntityFrameworkCore;
using SpeedRunWcf.Data.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace SpeedRunWcf.Infrastructure.Config {

    public class SpeedRunDatabaseContext : DbContext {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SpeedRunDatabase"].ToString());

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            var gameEntity = modelBuilder.Entity<Game>();

            gameEntity.ToTable("Game");

            gameEntity.HasKey(x => x.Id);

            gameEntity.Property(x => x.Id).HasColumnName("Id");
            gameEntity.Property(x => x.Name).HasColumnName("Name");
            gameEntity.Property(x => x.Publisher).HasColumnName("Publisher");
            gameEntity.Property(x => x.ReleaseDate).HasColumnName("ReleaseDate");

            var playerEntity = modelBuilder.Entity<Player>();

            playerEntity.ToTable("Player");

            playerEntity.HasKey(x => x.Id);

            playerEntity.HasAlternateKey(x => x.GamerTag);

            playerEntity.Property(x => x.Id).HasColumnName("Id");
            playerEntity.Property(x => x.GamerTag).HasColumnName("GamerTag");


            var speedRunEntity = modelBuilder.Entity<SpeedRun>();

            speedRunEntity.ToTable("SpeedRun");

            speedRunEntity.HasKey(x => x.Id);

            speedRunEntity.Property(x => x.Id).HasColumnName("Id");
            speedRunEntity.Property(x => x.RecordDate).HasColumnName("RecordDate");

            speedRunEntity.Property(x => x.Time)
                .HasConversion(x => x.Ticks, x => TimeSpan.FromTicks(x))
                .HasColumnName("Time");

            speedRunEntity.HasOne(x => x.Player).WithMany().HasForeignKey("PlayerId");
            speedRunEntity.HasOne(x => x.Game).WithMany().HasForeignKey("GameId");


        }


    }

}
