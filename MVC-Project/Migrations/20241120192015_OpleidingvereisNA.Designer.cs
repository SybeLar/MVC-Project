﻿// <auto-generated />
using System;
using MVC_Project_BSL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Project_BSL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241120192015_OpleidingvereisNA")]
    partial class OpleidingvereisNA
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_Project_BSL.Models.Activiteit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Activiteiten");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Bestemming", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BestemmingsNaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxLeeftijd")
                        .HasColumnType("int");

                    b.Property<int>("MinLeeftijd")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bestemmingen");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.CustomUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractNummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Geboortedatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gemeente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Huisdokter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Huisnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActief")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RekeningNummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoonNummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Deelnemer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroepsreisDetailId")
                        .HasColumnType("int");

                    b.Property<int>("KindId")
                        .HasColumnType("int");

                    b.Property<string>("Opmerkingen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReviewScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroepsreisDetailId");

                    b.HasIndex("KindId");

                    b.ToTable("Deelnemers");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Foto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BestemmingId")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BestemmingId");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Groepsreis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Begindatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("BestemmingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Einddatum")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<float>("Prijs")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("BestemmingId");

                    b.ToTable("Groepsreizen");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.GroepsreisMonitor", b =>
                {
                    b.Property<int>("GroepsreisId")
                        .HasColumnType("int");

                    b.Property<int>("MonitorId")
                        .HasColumnType("int");

                    b.HasKey("GroepsreisId", "MonitorId");

                    b.HasIndex("MonitorId");

                    b.ToTable("GroepsreisMonitor");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Kind", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Allergieen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Geboortedatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Medicatie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersoonId")
                        .HasColumnType("int");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersoonId");

                    b.ToTable("Kinderen");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Opleiding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AantalPlaatsen")
                        .HasColumnType("int");

                    b.Property<DateTime>("Begindatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Einddatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("OpleidingVereist")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Opleidingen");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.OpleidingPersoon", b =>
                {
                    b.Property<int>("OpleidingId")
                        .HasColumnType("int");

                    b.Property<int>("PersoonId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("OpleidingId", "PersoonId");

                    b.HasIndex("PersoonId");

                    b.ToTable("OpleidingPersonen");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Programma", b =>
                {
                    b.Property<int>("ActiviteitId")
                        .HasColumnType("int");

                    b.Property<int>("GroepsreisId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ActiviteitId", "GroepsreisId");

                    b.HasIndex("GroepsreisId");

                    b.ToTable("Programmas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Monitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsHoofdMonitor")
                        .HasColumnType("bit");

                    b.Property<int>("PersoonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersoonId");

                    b.ToTable("Monitoren");
                });

            modelBuilder.Entity("Onkosten", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Bedrag")
                        .HasColumnType("real");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroepsreisId")
                        .HasColumnType("int");

                    b.Property<string>("Omschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroepsreisId");

                    b.ToTable("Onkosten");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Deelnemer", b =>
                {
                    b.HasOne("MVC_Project_BSL.Models.Groepsreis", "GroepsreisDetail")
                        .WithMany("Deelnemers")
                        .HasForeignKey("GroepsreisDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Project_BSL.Models.Kind", "Kind")
                        .WithMany()
                        .HasForeignKey("KindId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroepsreisDetail");

                    b.Navigation("Kind");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Foto", b =>
                {
                    b.HasOne("MVC_Project_BSL.Models.Bestemming", "Bestemming")
                        .WithMany("Fotos")
                        .HasForeignKey("BestemmingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bestemming");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Groepsreis", b =>
                {
                    b.HasOne("MVC_Project_BSL.Models.Bestemming", "Bestemming")
                        .WithMany("Groepsreizen")
                        .HasForeignKey("BestemmingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bestemming");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.GroepsreisMonitor", b =>
                {
                    b.HasOne("MVC_Project_BSL.Models.Groepsreis", "Groepsreis")
                        .WithMany("Monitoren")
                        .HasForeignKey("GroepsreisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Monitor", "Monitor")
                        .WithMany("Groepsreizen")
                        .HasForeignKey("MonitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Groepsreis");

                    b.Navigation("Monitor");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Kind", b =>
                {
                    b.HasOne("MVC_Project_BSL.Models.CustomUser", "Persoon")
                        .WithMany("Kinderen")
                        .HasForeignKey("PersoonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persoon");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.OpleidingPersoon", b =>
                {
                    b.HasOne("MVC_Project_BSL.Models.Opleiding", "Opleiding")
                        .WithMany("OpleidingPersonen")
                        .HasForeignKey("OpleidingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Project_BSL.Models.CustomUser", "Persoon")
                        .WithMany("Opleidingen")
                        .HasForeignKey("PersoonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Opleiding");

                    b.Navigation("Persoon");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Programma", b =>
                {
                    b.HasOne("MVC_Project_BSL.Models.Activiteit", "Activiteit")
                        .WithMany("Programmas")
                        .HasForeignKey("ActiviteitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Project_BSL.Models.Groepsreis", "Groepsreis")
                        .WithMany("Programmas")
                        .HasForeignKey("GroepsreisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activiteit");

                    b.Navigation("Groepsreis");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("MVC_Project_BSL.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("MVC_Project_BSL.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Project_BSL.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("MVC_Project_BSL.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Monitor", b =>
                {
                    b.HasOne("MVC_Project_BSL.Models.CustomUser", "Persoon")
                        .WithMany("Monitoren")
                        .HasForeignKey("PersoonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persoon");
                });

            modelBuilder.Entity("Onkosten", b =>
                {
                    b.HasOne("MVC_Project_BSL.Models.Groepsreis", "Groepsreis")
                        .WithMany("Onkosten")
                        .HasForeignKey("GroepsreisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Groepsreis");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Activiteit", b =>
                {
                    b.Navigation("Programmas");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Bestemming", b =>
                {
                    b.Navigation("Fotos");

                    b.Navigation("Groepsreizen");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.CustomUser", b =>
                {
                    b.Navigation("Kinderen");

                    b.Navigation("Monitoren");

                    b.Navigation("Opleidingen");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Groepsreis", b =>
                {
                    b.Navigation("Deelnemers");

                    b.Navigation("Monitoren");

                    b.Navigation("Onkosten");

                    b.Navigation("Programmas");
                });

            modelBuilder.Entity("MVC_Project_BSL.Models.Opleiding", b =>
                {
                    b.Navigation("OpleidingPersonen");
                });

            modelBuilder.Entity("Monitor", b =>
                {
                    b.Navigation("Groepsreizen");
                });
#pragma warning restore 612, 618
        }
    }
}
