﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Entities.WeatherControl;
using Microsoft.EntityFrameworkCore;

namespace HwEFCoreWebAPI.Models
{
    public partial class ForecastContext : DbContext
    {
        public ForecastContext()
        {
        }

        public ForecastContext(DbContextOptions<ForecastContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Forecast> Forecasts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}