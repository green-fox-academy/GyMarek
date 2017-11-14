using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlpagaDictionary.Migrations
{
    public partial class ScoreAndDate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "DefinitionData",
                newName: "ModifiedDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "DefinitionData",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "DefinitionData");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "DefinitionData",
                newName: "Date");
        }
    }
}
