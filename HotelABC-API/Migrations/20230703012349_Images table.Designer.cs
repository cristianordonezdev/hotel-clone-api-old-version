﻿// <auto-generated />
using System;
using HotelABC_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelABC_API.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20230703012349_Images table")]
    partial class Imagestable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelABC_API.Models.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ImageTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RelativeRelationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("HotelABC_API.Models.Domain.ImageType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ImageTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3897b275-7a3f-4a84-a620-105b9b0eb89a"),
                            Type = "room"
                        },
                        new
                        {
                            Id = new Guid("e4567686-1b4d-483d-a374-9e99306c8e7b"),
                            Type = "carousel"
                        },
                        new
                        {
                            Id = new Guid("de63304d-8500-4570-8333-abb077e5a23f"),
                            Type = "food"
                        },
                        new
                        {
                            Id = new Guid("8929b4bf-5be3-4002-8ad6-b9f46f782f16"),
                            Type = "offers"
                        });
                });

            modelBuilder.Entity("HotelABC_API.Models.Domain.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Characteristics")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
