using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LagopusSpringExamPractise.Entities;

namespace LagopusSpringExamPractise.Migrations
{
    [DbContext(typeof(QAContext))]
    [Migration("20171115160153_qanda4")]
    partial class qanda4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LagopusSpringExamPractise.Models.QandA", b =>
                {
                    b.Property<int>("QandAId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<string>("Question");

                    b.HasKey("QandAId");

                    b.ToTable("QA");
                });

            modelBuilder.Entity("LagopusSpringExamPractise.Models.QandAtemp", b =>
                {
                    b.Property<int>("TempId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TempAnswer");

                    b.Property<string>("TempQuestion");

                    b.HasKey("TempId");

                    b.ToTable("QATemp");
                });
        }
    }
}
