using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AlpagaDictionary.Entities;

namespace AlpagaDictionary.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20171110094427_DefDataRe2")]
    partial class DefDataRe2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlpagaDictionary.Models.Definition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<string>("DefinitionName");

                    b.Property<string>("DefinitonDescription");

                    b.Property<int>("ModifiedBy");

                    b.HasKey("Id");

                    b.ToTable("DefinitionData");
                });

            modelBuilder.Entity("AlpagaDictionary.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginName");

                    b.Property<string>("Password");

                    b.HasKey("UserId");

                    b.ToTable("UserData");
                });
        }
    }
}
