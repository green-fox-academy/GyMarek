using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ExamPractise.Entities;

namespace ExamPractise.Migrations
{
    [DbContext(typeof(QuizContext))]
    partial class QuizContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamPractise.Models.Quiz", b =>
                {
                    b.Property<int>("QaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<string>("Question");

                    b.HasKey("QaId");

                    b.ToTable("QuizTable");
                });

            modelBuilder.Entity("ExamPractise.Models.RandomQuiz", b =>
                {
                    b.Property<int>("RandomQuizId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QaId");

                    b.HasKey("RandomQuizId");

                    b.ToTable("RandomQuizTable");
                });
        }
    }
}
