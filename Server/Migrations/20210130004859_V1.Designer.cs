﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Models;

namespace Server.Migrations
{
    [DbContext(typeof(AvionContext))]
    [Migration("20210130004859_V1")]
    partial class V1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Server.Models.Avion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int>("Kapacitet")
                        .HasColumnType("int")
                        .HasColumnName("Kapacitet");

                    b.Property<string>("Naziv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Naziv");

                    b.Property<int>("X")
                        .HasColumnType("int")
                        .HasColumnName("X");

                    b.Property<int>("Y")
                        .HasColumnType("int")
                        .HasColumnName("Y");

                    b.HasKey("ID");

                    b.ToTable("Avion");
                });

            modelBuilder.Entity("Server.Models.Lokacija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int?>("AvionID")
                        .HasColumnType("int");

                    b.Property<string>("Boja")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Boja");

                    b.Property<int>("Kapacitet")
                        .HasColumnType("int")
                        .HasColumnName("Kapacitet");

                    b.Property<int>("M")
                        .HasColumnType("int")
                        .HasColumnName("M");

                    b.Property<int>("MaxKapacitet")
                        .HasColumnType("int")
                        .HasColumnName("MaxKapacitet");

                    b.Property<int>("N")
                        .HasColumnType("int")
                        .HasColumnName("N");

                    b.Property<string>("Tip")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Tip");

                    b.HasKey("ID");

                    b.HasIndex("AvionID");

                    b.ToTable("Lokacija");
                });

            modelBuilder.Entity("Server.Models.Lokacija", b =>
                {
                    b.HasOne("Server.Models.Avion", "Avion")
                        .WithMany("Lokacije")
                        .HasForeignKey("AvionID");

                    b.Navigation("Avion");
                });

            modelBuilder.Entity("Server.Models.Avion", b =>
                {
                    b.Navigation("Lokacije");
                });
#pragma warning restore 612, 618
        }
    }
}
