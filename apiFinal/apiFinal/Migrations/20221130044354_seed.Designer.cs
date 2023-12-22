﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalServeur.Data;

namespace finalServeur.Migrations
{
    [DbContext(typeof(finalServeurContext))]
    [Migration("20221130044354_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("finalServeur.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MimeType")
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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111111",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "463b1a1a-0340-4206-8f2e-ebf901a99267",
                            Email = "n@n.n",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "N@N.N",
                            NormalizedUserName = "NICOLE",
                            PasswordHash = "AQAAAAEAACcQAAAAEFHoOBMDwcOQer02gdczcpq4hkAF+Es914XXr7swRMaZLuHKjd2yqe3Nw/0lQ9hGng==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "81300e7e-a01b-40f5-9641-f88e02372671",
                            TwoFactorEnabled = false,
                            UserName = "Nicole"
                        },
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111112",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "faf82f9f-7dba-482a-8667-cdf2a5bf87bb",
                            Email = "s@s.s",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "S@S.S",
                            NormalizedUserName = "SOLANGE",
                            PasswordHash = "AQAAAAEAACcQAAAAELpX5bVqds+iuTT64NUYpZraWMEwewL0OzI5thd9Vq1Cvaz0N4ivK9AvlZCv/v+m9Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "56f8e726-04e8-4a81-858c-0f000d10c7df",
                            TwoFactorEnabled = false,
                            UserName = "Solange"
                        },
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111113",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "329cbf8c-df8a-428f-9859-34acdbc2ecbb",
                            Email = "f@f.f",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "F@F.F",
                            NormalizedUserName = "FERNANDO",
                            PasswordHash = "AQAAAAEAACcQAAAAEBDNUV4/TL/8PmS2Qpp5UH8Y7wjsS6misJiUkvdVD1gvTWVJKU06jYMpYxJS77l60Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "22067a43-96ca-4075-94ed-3fd2fb2fabfd",
                            TwoFactorEnabled = false,
                            UserName = "Fernando"
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
