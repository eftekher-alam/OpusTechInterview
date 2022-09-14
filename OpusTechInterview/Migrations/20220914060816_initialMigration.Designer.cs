﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpusTechInterview.Models;

namespace OpusTechInterview.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220914060816_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("OpusTechInterview.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeCode")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeCode");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
