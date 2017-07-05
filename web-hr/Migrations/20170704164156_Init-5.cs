using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webhr.Migrations
{
    public partial class Init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Department_DeptID",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_DeptID",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "DeptID",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Person",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Person_DepartmentID",
                table: "Person",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Department_DepartmentID",
                table: "Person",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Department_DepartmentID",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_DepartmentID",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "DeptID",
                table: "Person",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_DeptID",
                table: "Person",
                column: "DeptID");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Department_DeptID",
                table: "Person",
                column: "DeptID",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
