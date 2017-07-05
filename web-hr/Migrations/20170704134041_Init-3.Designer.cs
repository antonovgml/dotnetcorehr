using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using webhr.Models;

namespace webhr.Migrations
{
    [DbContext(typeof(HRContext))]
    [Migration("20170704134041_Init-3")]
    partial class Init3
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

                    b.Property<int?>("DeptID");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PatronymicName");

                    b.Property<decimal>("Salary");

                    b.Property<int>("Sex");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("DeptID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("webhr.Models.Person", b =>
                {
                    b.HasOne("webhr.Models.Department", "Dept")
                        .WithMany("Persons")
                        .HasForeignKey("DeptID");
                });
        }
    }
}
