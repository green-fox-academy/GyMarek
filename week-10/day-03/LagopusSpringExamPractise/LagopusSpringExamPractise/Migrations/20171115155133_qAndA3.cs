using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LagopusSpringExamPractise.Migrations
{
    public partial class qAndA3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QA",
                table: "QA");

            migrationBuilder.RenameTable(
                name: "QA",
                newName: "QandA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QandA",
                table: "QandA",
                column: "QandAId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QandA",
                table: "QandA");

            migrationBuilder.RenameTable(
                name: "QandA",
                newName: "QA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QA",
                table: "QA",
                column: "QandAId");
        }
    }
}
