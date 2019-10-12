using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAPI.Migrations
{
    public partial class Library1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Freinds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Freinds",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "userid",
                table: "Freinds",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Freinds");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Freinds");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "Freinds");
        }
    }
}
