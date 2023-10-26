﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.DatabaseDbContext;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(FlightDbContext))]
    [Migration("20231026101224_add")]
    partial class add
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApplication2.Models.Flight", b =>
                {
                    b.Property<string>("FlightID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Loading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnLoading")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FlightID");

                    b.ToTable("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}