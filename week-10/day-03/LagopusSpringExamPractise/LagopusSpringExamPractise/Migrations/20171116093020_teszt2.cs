using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LagopusSpringExamPractise.Migrations
{
    public partial class teszt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "QATemp",
                columns: table => new
                {
                    QandAId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QATemp", x => x.QandAId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QATemp");

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
    }
}
