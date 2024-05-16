﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManager.DataAccess;

#nullable disable

namespace TaskManager.Migrations
{
    [DbContext(typeof(TaskManagerDbContext))]
    [Migration("20240514212717_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskManager.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("Active");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("Description");

                    b.Property<string>("DueDate")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("DueDate");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Description = "A test for a task",
                            DueDate = "30/04/2024",
                            StatusID = 1,
                            Title = "Test1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}