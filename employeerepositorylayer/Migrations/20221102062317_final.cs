using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee.Repository.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(3)", maxLength: 3, nullable: false),
                    First_name = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    Last_name = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<string>(type: "VARCHAR(7)", maxLength: 7, nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    Email_ID = table.Column<string>(type: "VARCHAR(25)", maxLength: 25, nullable: false),
                    Mobile_Number = table.Column<string>(type: "VARCHAR(64)", nullable: false),
                    Address = table.Column<string>(type: "VARCHAR(35)", maxLength: 35, nullable: false),
                    Country = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    Salary = table.Column<string>(type: "VARCHAR(64)", nullable: false),
                    Designation = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    upload_image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Add_designation = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TokenCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TokenExpires = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.username);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Login");
        }
    }
}
