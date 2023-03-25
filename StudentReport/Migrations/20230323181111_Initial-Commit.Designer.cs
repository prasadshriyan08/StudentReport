﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentReport.Data;

#nullable disable

namespace StudentReport.Migrations
{
    [DbContext(typeof(StudentsDbContext))]
    [Migration("20230323181111_Initial-Commit")]
    partial class InitialCommit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("StudentReport.Data.Classes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassName = "Physics"
                        },
                        new
                        {
                            Id = 2,
                            ClassName = "Chemistry"
                        },
                        new
                        {
                            Id = 3,
                            ClassName = "Mathematics"
                        },
                        new
                        {
                            Id = 4,
                            ClassName = "Biology"
                        });
                });

            modelBuilder.Entity("StudentReport.Data.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryName = "India"
                        },
                        new
                        {
                            Id = 2,
                            CountryName = "America"
                        },
                        new
                        {
                            Id = 3,
                            CountryName = "Canada"
                        });
                });

            modelBuilder.Entity("StudentReport.Data.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("CountryId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassId = 1,
                            CountryId = 1,
                            DOB = new DateOnly(1989, 4, 8),
                            Name = "John"
                        },
                        new
                        {
                            Id = 2,
                            ClassId = 2,
                            CountryId = 3,
                            DOB = new DateOnly(1982, 8, 7),
                            Name = "Abdul"
                        },
                        new
                        {
                            Id = 3,
                            ClassId = 4,
                            CountryId = 2,
                            DOB = new DateOnly(1972, 9, 1),
                            Name = "Prasad"
                        },
                        new
                        {
                            Id = 4,
                            ClassId = 3,
                            CountryId = 1,
                            DOB = new DateOnly(1986, 12, 23),
                            Name = "Kiran"
                        },
                        new
                        {
                            Id = 5,
                            ClassId = 4,
                            CountryId = 2,
                            DOB = new DateOnly(1995, 7, 12),
                            Name = "Mathew"
                        },
                        new
                        {
                            Id = 6,
                            ClassId = 2,
                            CountryId = 3,
                            DOB = new DateOnly(1976, 6, 18),
                            Name = "Priya"
                        });
                });

            modelBuilder.Entity("StudentReport.Data.Students", b =>
                {
                    b.HasOne("StudentReport.Data.Classes", "Classes")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentReport.Data.Countries", "Countries")
                        .WithMany("Students")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classes");

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("StudentReport.Data.Classes", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("StudentReport.Data.Countries", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}