﻿// <auto-generated />
using System;
using FootballPools.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FootballPools.Data.Migrations.Business
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FootballPools.Data.Leagues.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LeagueTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ParticipationPrice")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LeagueTypeId");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("FootballPools.Data.Leagues.LeagueInvitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("LeagueInvitations");
                });

            modelBuilder.Entity("FootballPools.Data.Leagues.LeagueMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Authorized")
                        .HasColumnType("bit");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("LeagueMembers");
                });

            modelBuilder.Entity("FootballPools.Data.Leagues.LeagueMemberPrediction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FirstParticipantScore")
                        .HasColumnType("int");

                    b.Property<int>("LeagueMemberId")
                        .HasColumnType("int");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("SecondParticipantScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeagueMemberId");

                    b.HasIndex("MatchId");

                    b.ToTable("LeagueMemberPredictions");
                });

            modelBuilder.Entity("FootballPools.Data.Leagues.LeagueType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeagueTypes");
                });

            modelBuilder.Entity("FootballPools.Data.Mundial.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("FootballPools.Data.Mundial.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("FirstParticipantId")
                        .HasColumnType("int");

                    b.Property<int?>("FirstParticipantScore")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SecondParticipantId")
                        .HasColumnType("int");

                    b.Property<int?>("SecondParticipantScore")
                        .HasColumnType("int");

                    b.Property<int>("StadiumId")
                        .HasColumnType("int");

                    b.Property<int?>("WinnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirstParticipantId");

                    b.HasIndex("SecondParticipantId");

                    b.HasIndex("StadiumId");

                    b.HasIndex("WinnerId");

                    b.ToTable("Matchs");
                });

            modelBuilder.Entity("FootballPools.Data.Mundial.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("FootballPools.Data.Mundial.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stadiums");
                });

            modelBuilder.Entity("FootballPools.Data.Mundial.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("FootballPools.Data.Leagues.League", b =>
                {
                    b.HasOne("FootballPools.Data.Leagues.LeagueType", "LeagueType")
                        .WithMany()
                        .HasForeignKey("LeagueTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeagueType");
                });

            modelBuilder.Entity("FootballPools.Data.Leagues.LeagueInvitation", b =>
                {
                    b.HasOne("FootballPools.Data.Leagues.League", "League")
                        .WithMany("LeagueInvitations")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("League");
                });

            modelBuilder.Entity("FootballPools.Data.Leagues.LeagueMember", b =>
                {
                    b.HasOne("FootballPools.Data.Leagues.League", "League")
                        .WithMany("LeagueMembers")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("League");
                });

            modelBuilder.Entity("FootballPools.Data.Leagues.LeagueMemberPrediction", b =>
                {
                    b.HasOne("FootballPools.Data.Leagues.LeagueMember", "LeagueMember")
                        .WithMany()
                        .HasForeignKey("LeagueMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballPools.Data.Mundial.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeagueMember");

                    b.Navigation("Match");
                });

            modelBuilder.Entity("FootballPools.Data.Mundial.Group", b =>
                {
                    b.HasOne("FootballPools.Data.Mundial.Tournament", "Tournament")
                        .WithMany("Groups")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("FootballPools.Data.Mundial.Match", b =>
                {
                    b.HasOne("FootballPools.Data.Mundial.Participant", "FirstParticipant")
                        .WithMany()
                        .HasForeignKey("FirstParticipantId");

                    b.HasOne("FootballPools.Data.Mundial.Participant", "SecondParticipant")
                        .WithMany()
                        .HasForeignKey("SecondParticipantId");

                    b.HasOne("FootballPools.Data.Mundial.Stadium", "Stadium")
                        .WithMany("Matches")
                        .HasForeignKey("StadiumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballPools.Data.Mundial.Participant", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerId");

                    b.Navigation("FirstParticipant");

                    b.Navigation("SecondParticipant");

                    b.Navigation("Stadium");

                    b.Navigation("Winner");
                });

            modelBuilder.Entity("FootballPools.Data.Mundial.Participant", b =>
                {
                    b.HasOne("FootballPools.Data.Mundial.Tournament", "Tournament")
                        .WithMany("Participants")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("FootballPools.Data.Leagues.League", b =>
                {
                    b.Navigation("LeagueInvitations");

                    b.Navigation("LeagueMembers");
                });

            modelBuilder.Entity("FootballPools.Data.Mundial.Stadium", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("FootballPools.Data.Mundial.Tournament", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}