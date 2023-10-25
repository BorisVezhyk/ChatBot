﻿// <auto-generated />
using System;
using GameApi.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameApi.Migrations
{
    [DbContext(typeof(GameDbContext))]
    partial class GameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("GameApi.DataAccess.Entities.Answer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BonusInSec")
                        .HasColumnType("INTEGER");

                    b.Property<char>("IsMain")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LevelId")
                        .HasColumnType("INTEGER");

                    b.Property<char>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("GameApi.DataAccess.Entities.Game", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FinishDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<char>("Status")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GameApi.DataAccess.Entities.Hint", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HintText")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LevelId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TimeInSec")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.ToTable("Hints");
                });

            modelBuilder.Entity("GameApi.DataAccess.Entities.Level", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CountRightAnswers")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FinishDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("GameId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("INTEGER");

                    b.Property<char?>("Status")
                        .HasColumnType("TEXT");

                    b.Property<long>("TimeInSec")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("GameApi.DataAccess.Entities.Answer", b =>
                {
                    b.HasOne("GameApi.DataAccess.Entities.Level", null)
                        .WithMany("Answers")
                        .HasForeignKey("LevelId");
                });

            modelBuilder.Entity("GameApi.DataAccess.Entities.Hint", b =>
                {
                    b.HasOne("GameApi.DataAccess.Entities.Level", null)
                        .WithMany("Hints")
                        .HasForeignKey("LevelId");
                });

            modelBuilder.Entity("GameApi.DataAccess.Entities.Level", b =>
                {
                    b.HasOne("GameApi.DataAccess.Entities.Game", "Game")
                        .WithMany("Levels")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GameApi.DataAccess.Entities.Game", b =>
                {
                    b.Navigation("Levels");
                });

            modelBuilder.Entity("GameApi.DataAccess.Entities.Level", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Hints");
                });
#pragma warning restore 612, 618
        }
    }
}
