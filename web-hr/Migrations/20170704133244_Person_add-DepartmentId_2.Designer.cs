﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using webhr.Models;

namespace webhr.Migrations
{
    [DbContext(typeof(HRContext))]
    [Migration("20170704133244_Person_add-DepartmentId_2")]
    partial class Person_addDepartmentId_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webhr.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("State");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("webhr.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PatronymicName");

                    b.Property<decimal>("Salary");

                    b.Property<int>("Sex");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("webhr.Models.Person", b =>
                {
                    b.HasOne("webhr.Models.Department", "Dept")
                        .WithMany("Persons")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
