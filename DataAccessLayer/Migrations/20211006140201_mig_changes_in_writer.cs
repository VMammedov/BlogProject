using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_changes_in_writer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WriterPasswordHash",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "WriterPasswordSalt",
                table: "Writers");

            migrationBuilder.AddColumn<string>(
                name: "WriterPassword",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WriterPassword",
                table: "Writers");

            migrationBuilder.AddColumn<byte[]>(
                name: "WriterPasswordHash",
                table: "Writers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "WriterPasswordSalt",
                table: "Writers",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
