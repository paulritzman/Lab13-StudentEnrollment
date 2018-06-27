﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentEnrollment.Data;

namespace StudentEnrollment.Migrations
{
    [DbContext(typeof(EnrolledStudentsDbContext))]
    [Migration("20180627034852_reAddDates")]
    partial class reAddDates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentEnrollment.Models.Class", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassName");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("InstructorName");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("StudentEnrollment.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassID");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<decimal>("GPA");

                    b.Property<int>("GradeYear");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("ClassID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentEnrollment.Models.Student", b =>
                {
                    b.HasOne("StudentEnrollment.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
