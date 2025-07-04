﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotoSerwis.Migrations
{
    /// <inheritdoc />
    public partial class AddNameToModelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Models");
        }
    }
}
