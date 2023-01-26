﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using yembis_backend.Models;

#nullable disable

namespace yembisbackend.Migrations
{
    [DbContext(typeof(RoadwatchContext))]
    partial class RoadwatchContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("yembis_backend.Models.Camera", b =>
                {
                    b.Property<int>("CameraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CameraID"));

                    b.Property<string>("MacAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CameraID");

                    b.ToTable("Cameras");
                });

            modelBuilder.Entity("yembis_backend.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationID"));

                    b.Property<DateTime?>("BeginPeriode")
                        .HasColumnType("date");

                    b.Property<int>("CameraID")
                        .HasColumnType("int");

                    b.Property<bool>("Current")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EindPeriode")
                        .HasColumnType("date");

                    b.Property<string>("Gemeente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Snelheidslimiet")
                        .HasColumnType("int");

                    b.Property<string>("Straat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Vrachtwagenvrijzone")
                        .HasColumnType("bit");

                    b.HasKey("LocationID");

                    b.HasIndex("CameraID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("yembis_backend.Models.Meting", b =>
                {
                    b.Property<int>("MetingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MetingID"));

                    b.Property<int>("CameraID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumTijd")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Overschreden")
                        .HasColumnType("bit");

                    b.Property<int>("Snelheid")
                        .HasColumnType("int");

                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.HasKey("MetingID");

                    b.HasIndex("CameraID");

                    b.HasIndex("TypeID");

                    b.ToTable("Metings");
                });

            modelBuilder.Entity("yembis_backend.Models.Type", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeID"));

                    b.Property<string>("TypeVoertuig")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeID");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("yembis_backend.Models.Location", b =>
                {
                    b.HasOne("yembis_backend.Models.Camera", "Camera")
                        .WithMany()
                        .HasForeignKey("CameraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Camera");
                });

            modelBuilder.Entity("yembis_backend.Models.Meting", b =>
                {
                    b.HasOne("yembis_backend.Models.Camera", "Camera")
                        .WithMany()
                        .HasForeignKey("CameraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yembis_backend.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Camera");

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
