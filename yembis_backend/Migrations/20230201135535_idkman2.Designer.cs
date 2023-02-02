﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using yembis_backend.Models;

#nullable disable

namespace yembisbackend.Migrations
{
    [DbContext(typeof(RoadwatchContext))]
    [Migration("20230201135535_idkman2")]
    partial class idkman2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("yembis_backend.Models.Camera", b =>
                {
                    b.Property<int>("CameraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CameraID"), 1L, 1);

                    b.Property<string>("MacAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CameraID");

                    b.ToTable("Cameras");
                });

            modelBuilder.Entity("yembis_backend.Models.Categorie", b =>
                {
                    b.Property<int>("CategorieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategorieID"), 1L, 1);

                    b.Property<string>("TypeVoertuig")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategorieID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("yembis_backend.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationID"), 1L, 1);

                    b.Property<DateTime>("BeginPeriode")
                        .HasColumnType("datetime2");

                    b.Property<int>("CameraID")
                        .HasColumnType("int");

                    b.Property<bool>("Current")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EindPeriode")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gemeente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Vrachtwagenvrijzone")
                        .HasColumnType("bit");

                    b.HasKey("LocationID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("yembis_backend.Models.Meting", b =>
                {
                    b.Property<int>("MetingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MetingID"), 1L, 1);

                    b.Property<int>("CameraID")
                        .HasColumnType("int");

                    b.Property<int>("CategorieID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumTijd")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<bool>("Overschreden")
                        .HasColumnType("bit");

                    b.Property<int>("Snelheid")
                        .HasColumnType("int");

                    b.HasKey("MetingID");

                    b.HasIndex("CameraID");

                    b.HasIndex("CategorieID");

                    b.ToTable("Metings");
                });

            modelBuilder.Entity("yembis_backend.Models.SpeedLimit", b =>
                {
                    b.Property<int>("LimitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LimitID"), 1L, 1);

                    b.Property<int>("CategorieID")
                        .HasColumnType("int");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<int>("Snelheidslimiet")
                        .HasColumnType("int");

                    b.HasKey("LimitID");

                    b.HasIndex("CategorieID");

                    b.HasIndex("LocationID");

                    b.ToTable("SpeedLimits");
                });

            modelBuilder.Entity("yembis_backend.Models.Meting", b =>
                {
                    b.HasOne("yembis_backend.Models.Camera", "Camera")
                        .WithMany()
                        .HasForeignKey("CameraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yembis_backend.Models.Categorie", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Camera");

                    b.Navigation("Categorie");
                });

            modelBuilder.Entity("yembis_backend.Models.SpeedLimit", b =>
                {
                    b.HasOne("yembis_backend.Models.Categorie", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yembis_backend.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");

                    b.Navigation("Location");
                });
#pragma warning restore 612, 618
        }
    }
}
