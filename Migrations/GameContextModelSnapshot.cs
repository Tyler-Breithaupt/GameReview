﻿// <auto-generated />
using System;
using GameReview.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameReview.Migrations
{
    [DbContext(typeof(GameContext))]
    partial class GameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GameReview.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Rating = 10,
                            ReleaseDate = new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "An open-world masterpiece with endless exploration!",
                            Title = "The Legend of Zelda: Breath of the Wild"
                        },
                        new
                        {
                            Id = 2,
                            Rating = 9,
                            ReleaseDate = new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "Immersive storytelling in a stunning Wild West setting.",
                            Title = "Red Dead Redemption 2"
                        },
                        new
                        {
                            Id = 3,
                            Rating = 10,
                            ReleaseDate = new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "A fantastic blend of action and a heartfelt story of fatherhood.",
                            Title = "God of War"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
