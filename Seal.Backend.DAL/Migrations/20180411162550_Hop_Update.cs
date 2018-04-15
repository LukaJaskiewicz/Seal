using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Seal.Backend.DAL.Migrations
{
    public partial class Hop_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cantry",
                table: "Hops",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Hops",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Packed",
                table: "Hops",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantry",
                table: "Hops");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Hops");

            migrationBuilder.DropColumn(
                name: "Packed",
                table: "Hops");
        }
    }
}
