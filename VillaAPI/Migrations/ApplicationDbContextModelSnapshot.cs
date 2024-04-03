﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VillaAPI.Data;

#nullable disable

namespace VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "Private pool, Wi-Fi, Air conditioning",
                            CreatedDate = new DateTime(2024, 3, 3, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3162),
                            Details = "Spacious luxury villa with stunning ocean views",
                            ImageUrl = "https://example.com/images/villa1.jpg",
                            Name = "Luxury Villa",
                            Occupancy = 8,
                            Rate = 5.0,
                            Sqft = 3000,
                            UpdatedDate = new DateTime(2024, 3, 28, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3188)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Garden, BBQ, Beach access",
                            CreatedDate = new DateTime(2024, 3, 8, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3212),
                            Details = "Beautiful beachfront villa with direct access to the beach",
                            ImageUrl = "https://example.com/images/villa2.jpg",
                            Name = "Beachfront Villa",
                            Occupancy = 6,
                            Rate = 4.0,
                            Sqft = 2500,
                            UpdatedDate = new DateTime(2024, 3, 30, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3214)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Fireplace, Hiking trails",
                            CreatedDate = new DateTime(2024, 3, 13, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3220),
                            Details = "Cozy villa nestled in the mountains with scenic views",
                            ImageUrl = "https://example.com/images/villa3.jpg",
                            Name = "Mountain Retreat",
                            Occupancy = 4,
                            Rate = 3.0,
                            Sqft = 2000,
                            UpdatedDate = new DateTime(2024, 3, 31, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3221)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "Children's playground, Game room",
                            CreatedDate = new DateTime(2024, 3, 18, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3226),
                            Details = "Family-friendly villa with a large backyard and play area",
                            ImageUrl = "https://example.com/images/villa4.jpg",
                            Name = "Family Villa",
                            Occupancy = 6,
                            Rate = 3.5,
                            Sqft = 2200,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3229)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "Swimming pool, Gym, Smart home features",
                            CreatedDate = new DateTime(2024, 3, 23, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3234),
                            Details = "Stylish and modern villa with contemporary design",
                            ImageUrl = "https://example.com/images/villa5.jpg",
                            Name = "Modern Villa",
                            Occupancy = 8,
                            Rate = 4.5,
                            Sqft = 2800,
                            UpdatedDate = new DateTime(2024, 4, 2, 16, 40, 27, 948, DateTimeKind.Local).AddTicks(3236)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}