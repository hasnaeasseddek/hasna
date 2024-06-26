﻿// <auto-generated />
using System;
using Freelance.InfrastructurData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Freelance.Infrastructur.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Freelance.Data.Entities.Candidat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Disponibilite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GitHub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdUserReference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobilite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tele")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bumberOfLikes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Candidat");
                });

            modelBuilder.Entity("Freelance.Data.Entities.Entreprise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdUserReference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RaisonSociale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entreprises");
                });

            modelBuilder.Entity("Freelance.Data.Entities.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCondidat")
                        .HasColumnType("int");

                    b.Property<string>("Local")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCondidat");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Freelance.Data.Entities.Formation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diplome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ecole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCondidat")
                        .HasColumnType("int");

                    b.Property<string>("Niveau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCondidat");

                    b.ToTable("Formations");
                });

            modelBuilder.Entity("Freelance.Data.Entities.Offre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatePub")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrpition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdEntreprise")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdEntreprise");

                    b.ToTable("Offres");
                });

            modelBuilder.Entity("Freelance.Data.Entities.Projet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCondidat")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCondidat");

                    b.ToTable("Projets");
                });

            modelBuilder.Entity("Freelance.Data.Entities.Experience", b =>
                {
                    b.HasOne("Freelance.Data.Entities.Candidat", "Candidat")
                        .WithMany("Experiences")
                        .HasForeignKey("IdCondidat");

                    b.Navigation("Candidat");
                });

            modelBuilder.Entity("Freelance.Data.Entities.Formation", b =>
                {
                    b.HasOne("Freelance.Data.Entities.Candidat", "Candidat")
                        .WithMany("Formations")
                        .HasForeignKey("IdCondidat");

                    b.Navigation("Candidat");
                });

            modelBuilder.Entity("Freelance.Data.Entities.Offre", b =>
                {
                    b.HasOne("Freelance.Data.Entities.Entreprise", "Entreprise")
                        .WithMany("Offres")
                        .HasForeignKey("IdEntreprise");

                    b.Navigation("Entreprise");
                });

            modelBuilder.Entity("Freelance.Data.Entities.Projet", b =>
                {
                    b.HasOne("Freelance.Data.Entities.Candidat", "Candidat")
                        .WithMany("Projets")
                        .HasForeignKey("IdCondidat");

                    b.Navigation("Candidat");
                });

            modelBuilder.Entity("Freelance.Data.Entities.Candidat", b =>
                {
                    b.Navigation("Experiences");

                    b.Navigation("Formations");

                    b.Navigation("Projets");
                });

            modelBuilder.Entity("Freelance.Data.Entities.Entreprise", b =>
                {
                    b.Navigation("Offres");
                });
#pragma warning restore 612, 618
        }
    }
}
