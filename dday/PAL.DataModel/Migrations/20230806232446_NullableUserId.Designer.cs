﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PAL.DataModel;

#nullable disable

namespace PAL.DataModel.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230806232446_NullableUserId")]
    partial class NullableUserId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
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

            modelBuilder.Entity("PAL.DataModel.AKICSlot", b =>
                {
                    b.Property<int>("AKICSlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AKICSlotId"));

                    b.Property<string>("AKICCampus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AKICReservationId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AKICSlotId");

                    b.ToTable("AKICSlotsINV", (string)null);

                    b.HasData(
                        new
                        {
                            AKICSlotId = 1,
                            AKICCampus = "AKIC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            AKICSlotId = 2,
                            AKICCampus = "AKIC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            AKICSlotId = 3,
                            AKICCampus = "AKIC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            AKICSlotId = 4,
                            AKICCampus = "AKIC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            AKICSlotId = 5,
                            AKICCampus = "AKIC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            AKICSlotId = 6,
                            AKICCampus = "AKIC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            AKICSlotId = 7,
                            AKICCampus = "AKIC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            AKICSlotId = 8,
                            AKICCampus = "AKIC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            AKICSlotId = 9,
                            AKICCampus = "AKIC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            AKICSlotId = 10,
                            AKICCampus = "AKIC",
                            Status = "Unoccupied"
                        });
                });

            modelBuilder.Entity("PAL.DataModel.ApplicationUser", b =>
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
                });

            modelBuilder.Entity("PAL.DataModel.CampusReservation", b =>
                {
                    b.Property<int>("CampusReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampusReservationId"));

                    b.Property<string>("Campus")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("DateTime2(7)");

                    b.Property<string>("PlateNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("SlotId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("DateTime2(7)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("CampusReservationId");

                    b.ToTable("CampusReserveINV", (string)null);
                });

            modelBuilder.Entity("PAL.DataModel.DACSlot", b =>
                {
                    b.Property<int>("DACSlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DACSlotId"));

                    b.Property<string>("DACCampus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DACReservationId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DACSlotId");

                    b.ToTable("SlotsINV", (string)null);

                    b.HasData(
                        new
                        {
                            DACSlotId = 1,
                            DACCampus = "DAC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DACSlotId = 2,
                            DACCampus = "DAC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DACSlotId = 3,
                            DACCampus = "DAC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DACSlotId = 4,
                            DACCampus = "DAC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DACSlotId = 5,
                            DACCampus = "DAC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DACSlotId = 6,
                            DACCampus = "DAC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DACSlotId = 7,
                            DACCampus = "DAC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DACSlotId = 8,
                            DACCampus = "DAC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DACSlotId = 9,
                            DACCampus = "DAC",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DACSlotId = 10,
                            DACCampus = "DAC",
                            Status = "Unoccupied"
                        });
                });

            modelBuilder.Entity("PAL.DataModel.DOMINGASlot", b =>
                {
                    b.Property<int>("DOMINGASlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DOMINGASlotId"));

                    b.Property<string>("DOMINGACampus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DOMINGAReservationId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DOMINGASlotId");

                    b.ToTable("DOMINGASlotsINV", (string)null);

                    b.HasData(
                        new
                        {
                            DOMINGASlotId = 1,
                            DOMINGACampus = "DOMINGA",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DOMINGASlotId = 2,
                            DOMINGACampus = "DOMINGA",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DOMINGASlotId = 3,
                            DOMINGACampus = "DOMINGA",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DOMINGASlotId = 4,
                            DOMINGACampus = "DOMINGA",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DOMINGASlotId = 5,
                            DOMINGACampus = "DOMINGA",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DOMINGASlotId = 6,
                            DOMINGACampus = "DOMINGA",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DOMINGASlotId = 7,
                            DOMINGACampus = "DOMINGA",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DOMINGASlotId = 8,
                            DOMINGACampus = "DOMINGA",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DOMINGASlotId = 9,
                            DOMINGACampus = "DOMINGA",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            DOMINGASlotId = 10,
                            DOMINGACampus = "DOMINGA",
                            Status = "Unoccupied"
                        });
                });

            modelBuilder.Entity("PAL.DataModel.PETERSlot", b =>
                {
                    b.Property<int>("PETERSlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PETERSlotId"));

                    b.Property<string>("PETERCampus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PETERReservationId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PETERSlotId");

                    b.ToTable("PETERSlotsINV", (string)null);

                    b.HasData(
                        new
                        {
                            PETERSlotId = 1,
                            PETERCampus = "PDGII",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            PETERSlotId = 2,
                            PETERCampus = "PDGII",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            PETERSlotId = 3,
                            PETERCampus = "PDGII",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            PETERSlotId = 4,
                            PETERCampus = "PDGII",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            PETERSlotId = 5,
                            PETERCampus = "PDGII",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            PETERSlotId = 6,
                            PETERCampus = "PDGII",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            PETERSlotId = 7,
                            PETERCampus = "PDGII",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            PETERSlotId = 8,
                            PETERCampus = "PDGII",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            PETERSlotId = 9,
                            PETERCampus = "PDGII",
                            Status = "Unoccupied"
                        },
                        new
                        {
                            PETERSlotId = 10,
                            PETERCampus = "PDGII",
                            Status = "Unoccupied"
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
                    b.HasOne("PAL.DataModel.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PAL.DataModel.ApplicationUser", null)
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

                    b.HasOne("PAL.DataModel.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PAL.DataModel.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
