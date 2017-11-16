using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LagopusSpringExamPractise.Entities;

namespace LagopusSpringExamPractise.Migrations
{
    [DbContext(typeof(QAContext))]
    [Migration("20171116094259_test3")]
    partial class test3
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

            modelBuilder.Entity("LagopusSpringExamPractise.Models.Quiz", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QandAId");

                    b.HasKey("QuizId");

                    b.ToTable("QAQuiz");
                });
        }
    }
}
