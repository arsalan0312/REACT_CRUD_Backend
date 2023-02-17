using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace REACT_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class added_IsDeleted_Column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Employees",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DepartmentTypes",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DepartmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("1deef805-3402-4fa2-a68e-ee500347f895"),
                column: "IsDeleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "DepartmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("2669004f-85a5-4a5f-9ec0-34ffb84f0e87"),
                column: "IsDeleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "DepartmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("4bbf626e-e5d0-48a5-b590-a9ddf4cda0aa"),
                column: "IsDeleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "DepartmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("8e0dd012-46e8-4ca7-8612-cfc780d26ffc"),
                column: "IsDeleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "DepartmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("c8678960-f943-4be6-bca3-2a28218d1556"),
                column: "IsDeleted",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DepartmentTypes");
        }
    }
}
