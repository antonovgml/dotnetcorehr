using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webhr.Migrations
{
    public partial class Stuff_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Departments_DepartmentID",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Persons",
                newName: "DeptID");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_DepartmentID",
                table: "Persons",
                newName: "IX_Persons_DeptID");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Departments_DeptID",
                table: "Persons",
                column: "DeptID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Departments_DeptID",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "DeptID",
                table: "Persons",
                newName: "DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_DeptID",
                table: "Persons",
                newName: "IX_Persons_DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Departments_DepartmentID",
                table: "Persons",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
