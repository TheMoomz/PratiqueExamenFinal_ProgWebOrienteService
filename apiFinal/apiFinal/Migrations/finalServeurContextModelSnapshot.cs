﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalServeur.Data;

#nullable disable

namespace finalServeur.Migrations
{
    [DbContext(typeof(finalServeurContext))]
    partial class finalServeurContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "5327c04f-8a30-432e-9efa-278cdf69afed",
                            Email = "n@n.n",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "N@N.N",
                            NormalizedUserName = "NICOLE",
                            PasswordHash = "AQAAAAIAAYagAAAAEAka4aYD53rPVW3ck3uf8rm65iyCP7LL1Gr2w2Jxv0wk0Kbz0epWlay6y6Eo8mnZvQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c97ceb7b-4ef1-423b-b280-e0e365cb357c",
                            TwoFactorEnabled = false,
                            UserName = "Nicole"
                        },
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111112",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2525f7cc-1cdf-4a8e-aa89-30dad00e1dc4",
                            Email = "s@s.s",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "S@S.S",
                            NormalizedUserName = "SOLANGE",
                            PasswordHash = "AQAAAAIAAYagAAAAEOagZPJjU7nvVzYFnFceYBVp4/E//FisO0g+PI1eGmp9yJU4HfOsuoOaLxj5PM9T9Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e2511565-cafd-4f9d-8ce5-84fdad51cc63",
                            TwoFactorEnabled = false,
                            UserName = "Solange"
                        },
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111113",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5c2fc218-ab55-4274-aef4-052adbee59e0",
                            Email = "f@f.f",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "F@F.F",
                            NormalizedUserName = "FERNANDO",
                            PasswordHash = "AQAAAAIAAYagAAAAEGF+8Aat/i3zHnEvYjiUVYVYa9BbVV19VxUwVHY5sJgZso3MDWAkUcFo3UR4JgK1Aw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "15b814bc-ec29-4cfd-adb3-e7928ddd2dc6",
                            TwoFactorEnabled = false,
                            UserName = "Fernando"
                        },
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111114",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "02fcbdca-10b8-4e37-973b-e62a1276848d",
                            Email = "m@m.m",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "M@M.M",
                            NormalizedUserName = "MARC",
                            PasswordHash = "AQAAAAIAAYagAAAAEPMOqYWvWbxXGCjvPDSILYpmGSB0QK60zHmgAN3p8wfeDMJ8SF713/uLv+wXVb/q1Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c8641ce7-95b4-481c-903e-ac15c5b92b93",
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
