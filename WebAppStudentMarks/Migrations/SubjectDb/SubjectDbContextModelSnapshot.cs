﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppStudentMarks.Data;

#nullable disable

namespace WebAppStudentMarks.Migrations.SubjectDb
{
    [DbContext(typeof(SubjectDbContext))]
    partial class SubjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAppStudentMarks.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("SubName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Subcode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Subject");
                });
#pragma warning restore 612, 618
        }
    }
}