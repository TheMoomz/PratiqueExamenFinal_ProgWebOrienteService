﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalServeur.Data;

#nullable disable

namespace finalServeur.Migrations
{
    [DbContext(typeof(finalServeurContext))]
    [Migration("20231222063750_seedNewUser")]
    partial class seedNewUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("finalServeur.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MimeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TweetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TweetId")
                        .IsUnique();

                    b.ToTable("Picture");
                });

            modelBuilder.Entity("finalServeur.Models.Tweet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AnswerToId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AnswerToId");

                    b.HasIndex("UserId");

                    b.ToTable("Tweet");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Score = 1,
                            Text = "Lorsque mon chat veut sortir et qu'il voit qu'il pleut dans la porte arrière, il veut que j'aille lui ouvrir la porte avant pour vérifier s'il pleut aussi dans l'autre univers\r\n-Nicole",
                            UserId = "11111111-1111-1111-1111-111111111111"
                        },
                        new
                        {
                            Id = 2,
                            Score = 0,
                            Text = "AAAAAAAAAAAAAAAAAAAAAAAA\r\n-Solange",
                            UserId = "11111111-1111-1111-1111-111111111112"
                        },
                        new
                        {
                            Id = 3,
                            AnswerToId = 1,
                            Score = -1,
                            Text = "Inutile d'essayer de raconter une histoire drôle Nicole, les étudiants sont en plein examen et doivent se concentrer.\r\n-Fernando",
                            UserId = "11111111-1111-1111-1111-111111111113"
                        },
                        new
                        {
                            Id = 4,
                            AnswerToId = 2,
                            Score = 2,
                            Text = "ok\r\n-Nicole",
                            UserId = "11111111-1111-1111-1111-111111111111"
                        });
                });

            modelBuilder.Entity("finalServeur.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111111",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "459c1d12-9c29-40b9-81c0-e7082baa20ef",
                            Email = "n@n.n",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "N@N.N",
                            NormalizedUserName = "NICOLE",
                            PasswordHash = "AQAAAAIAAYagAAAAEHTGUadh4s0/CV8ShxKYrbMZkEUGhd535URtHY3K6tIgHpwGkpD8Cwa3AJbxT2lTmw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "76dbb116-5508-4110-90e1-0847c59aeaf8",
                            TwoFactorEnabled = false,
                            UserName = "Nicole"
                        },
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111112",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1b30a36b-2a1f-445c-ab17-a8b65ef98315",
                            Email = "s@s.s",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "S@S.S",
                            NormalizedUserName = "SOLANGE",
                            PasswordHash = "AQAAAAIAAYagAAAAEI8xsOCCdW3DbPLFUqVTyS1gjIpm17F9DNPHjmYI46FqWpYyWQs95N8/VT5eLIz0oQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "11b59b13-f1ef-48a3-a7d7-c098104c44ab",
                            TwoFactorEnabled = false,
                            UserName = "Solange"
                        },
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111113",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b6d219a6-d51f-44f6-a4ac-83511a03e8c2",
                            Email = "f@f.f",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "F@F.F",
                            NormalizedUserName = "FERNANDO",
                            PasswordHash = "AQAAAAIAAYagAAAAEO41b8VK+OXl+5ZpAHxVygEXpBheElQxYXfmsqsKY6J43OjjIh5s7NM4UzUUCJoO/A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "78b4f07f-0e29-402f-9904-061ce8acfb1e",
                            TwoFactorEnabled = false,
                            UserName = "Fernando"
                        },
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111114",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3d41ea38-de90-436b-b80b-c3ac99131894",
                            Email = "m@m.m",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "M@M.M",
                            NormalizedUserName = "MARC",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "30e628b3-3484-4454-ae06-3dc4d29ef08c",
                            TwoFactorEnabled = false,
                            UserName = "Marc"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("finalServeur.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("finalServeur.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("finalServeur.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("finalServeur.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("finalServeur.Models.Picture", b =>
                {
                    b.HasOne("finalServeur.Models.Tweet", "Tweet")
                        .WithOne("Picture")
                        .HasForeignKey("finalServeur.Models.Picture", "TweetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tweet");
                });

            modelBuilder.Entity("finalServeur.Models.Tweet", b =>
                {
                    b.HasOne("finalServeur.Models.Tweet", "AnswerTo")
                        .WithMany("Answers")
                        .HasForeignKey("AnswerToId");

                    b.HasOne("finalServeur.Models.User", "User")
                        .WithMany("Tweets")
                        .HasForeignKey("UserId");

                    b.Navigation("AnswerTo");

                    b.Navigation("User");
                });

            modelBuilder.Entity("finalServeur.Models.Tweet", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("finalServeur.Models.User", b =>
                {
                    b.Navigation("Tweets");
                });
#pragma warning restore 612, 618
        }
    }
}
