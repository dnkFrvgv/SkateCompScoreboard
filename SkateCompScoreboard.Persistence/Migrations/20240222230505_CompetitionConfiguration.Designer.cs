﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkateCompScoreboard.Persistence.Data;

#nullable disable

namespace SkateCompScoreboard.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240222230505_CompetitionConfiguration")]
    partial class CompetitionConfiguration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Acronym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Competition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Modality")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfRounds")
                        .HasColumnType("int");

                    b.Property<DateTime>("OpenningDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Competitions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7f985804-d3ef-4816-8876-48eb5de6b134"),
                            Category = "f",
                            Modality = 0,
                            Name = "SLS Sidney 2024: Women's Tournament",
                            NumberOfRounds = 3,
                            OpenningDate = new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 2
                        },
                        new
                        {
                            Id = new Guid("996eecb7-3ca5-4546-b157-dadc0accbd1e"),
                            Category = "m",
                            Modality = 2,
                            Name = "XGames Japan 2024: Man's Vert",
                            NumberOfRounds = 2,
                            OpenningDate = new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 2
                        },
                        new
                        {
                            Id = new Guid("c96cc4b3-b405-4dc9-b2b4-650b9300ff3a"),
                            Category = "f",
                            Modality = 1,
                            Name = "XGames Japan 2024: Women's Park",
                            NumberOfRounds = 3,
                            OpenningDate = new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 2
                        });
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Competitor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OriginId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OriginId");

                    b.ToTable("Competitors");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Round", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompetitionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfCompetitors")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSections")
                        .HasColumnType("int");

                    b.Property<int>("RoundOrder")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionId");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.RoundCompetitor", b =>
                {
                    b.Property<Guid>("RoundId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompetitorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("PodiumOrder")
                        .HasColumnType("int");

                    b.HasKey("RoundId", "CompetitorId");

                    b.HasIndex("CompetitorId");

                    b.ToTable("RoundCompetitors");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Score", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("FinalScore")
                        .HasColumnType("real");

                    b.Property<Guid?>("RoundCompetitorCompetitorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoundCompetitorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RoundCompetitorRoundId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TrickId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.HasIndex("TrickId");

                    b.HasIndex("RoundCompetitorRoundId", "RoundCompetitorCompetitorId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Section", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoundId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SectionOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoundId");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Trick", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tricks");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.LineSection", b =>
                {
                    b.HasBaseType("SkateCompScoreboard.Core.Entities.Section");

                    b.ToTable("LineSections");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.SingleTrickSection", b =>
                {
                    b.HasBaseType("SkateCompScoreboard.Core.Entities.Section");

                    b.ToTable("SingleTrickSections");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Competition", b =>
                {
                    b.HasOne("SkateCompScoreboard.Core.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Competitor", b =>
                {
                    b.HasOne("SkateCompScoreboard.Core.Entities.Address", "Origin")
                        .WithMany()
                        .HasForeignKey("OriginId");

                    b.Navigation("Origin");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Round", b =>
                {
                    b.HasOne("SkateCompScoreboard.Core.Entities.Competition", "Competition")
                        .WithMany("Rounds")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competition");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.RoundCompetitor", b =>
                {
                    b.HasOne("SkateCompScoreboard.Core.Entities.Competitor", "Competitor")
                        .WithMany("Rounds")
                        .HasForeignKey("CompetitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkateCompScoreboard.Core.Entities.Round", "Round")
                        .WithMany("Competitors")
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competitor");

                    b.Navigation("Round");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Score", b =>
                {
                    b.HasOne("SkateCompScoreboard.Core.Entities.Section", "Section")
                        .WithMany("Scores")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkateCompScoreboard.Core.Entities.Trick", "Trick")
                        .WithMany()
                        .HasForeignKey("TrickId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkateCompScoreboard.Core.Entities.RoundCompetitor", "RoundCompetitor")
                        .WithMany("Scores")
                        .HasForeignKey("RoundCompetitorRoundId", "RoundCompetitorCompetitorId");

                    b.Navigation("RoundCompetitor");

                    b.Navigation("Section");

                    b.Navigation("Trick");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Section", b =>
                {
                    b.HasOne("SkateCompScoreboard.Core.Entities.Round", "Round")
                        .WithMany("Sections")
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Round");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Competition", b =>
                {
                    b.Navigation("Rounds");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Competitor", b =>
                {
                    b.Navigation("Rounds");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Round", b =>
                {
                    b.Navigation("Competitors");

                    b.Navigation("Sections");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.RoundCompetitor", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("SkateCompScoreboard.Core.Entities.Section", b =>
                {
                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
