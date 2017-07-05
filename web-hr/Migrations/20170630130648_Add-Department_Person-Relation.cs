using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webhr.Migrations
{
    public partial class AddDepartment_PersonRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "state",
                table: "Department",
                newName: "State");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Person",
                nullable: true);

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
                onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Department",
                newName: "state");
        }
    }
}
