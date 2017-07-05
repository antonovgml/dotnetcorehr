using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webhr.Migrations
{
    public partial class Stuff_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Persons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DepartmentID",
                table: "Persons",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Departments_DepartmentID",
                table: "Persons",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Departments_DepartmentID",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_DepartmentID",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Persons");
        }
    }
}
