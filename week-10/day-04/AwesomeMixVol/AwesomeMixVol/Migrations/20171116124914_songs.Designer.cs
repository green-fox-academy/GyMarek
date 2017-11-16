using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AwesomeMixVol.Entities;

namespace AwesomeMixVol.Migrations
{
    [DbContext(typeof(SongContext))]
    [Migration("20171116124914_songs")]
    partial class songs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AwesomeMixVol.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Genre");

                    b.Property<double>("Rating");

                    b.Property<string>("Title");

                    b.Property<int>("Year");

                    b.HasKey("SongId");

                    b.ToTable("Songs");
                });
        }
    }
}
