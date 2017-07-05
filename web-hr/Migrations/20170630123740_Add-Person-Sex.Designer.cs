using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using webhr.Models;

namespace webhr.Migrations
{
    [DbContext(typeof(HRContext))]
    [Migration("20170630123740_Add-Person-Sex")]
    partial class AddPersonSex
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

                    b.Property<string>("Title");

                    b.Property<int>("state");

                    b.HasKey("ID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("webhr.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PatronymicName");

                    b.Property<decimal>("Salary");

                    b.Property<int>("Sex");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });
        }
    }
}
