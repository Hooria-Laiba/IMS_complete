﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMSIdentity.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CartItems");
        }
    }
}
