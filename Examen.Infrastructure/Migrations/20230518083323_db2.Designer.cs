﻿// <auto-generated />
using System;
using Examen.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    [DbContext(typeof(ExamenContext))]
    [Migration("20230518083323_db2")]
    partial class db2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("adresse")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Prestataire", b =>
                {
                    b.Property<int>("PrestataireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrestataireId"));

                    b.Property<string>("PageInstagram")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PrestataireNom")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Zone")
                        .HasColumnType("int");

                    b.Property<int>("note")
                        .HasColumnType("int");

                    b.Property<string>("prestataireTel")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("PrestataireId");

                    b.ToTable("Prestataires");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Prestation", b =>
                {
                    b.Property<int>("PrestationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrestationId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Intitule")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("PrestataireFK")
                        .HasColumnType("int");

                    b.Property<int>("PrestationTyp")
                        .HasColumnType("int");

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.HasKey("PrestationId");

                    b.HasIndex("PrestataireFK");

                    b.ToTable("prestations");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.RDV", b =>
                {
                    b.Property<int>("PrestationFK")
                        .HasColumnType("int");

                    b.Property<int>("ClientFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRDv")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Confimration")
                        .HasColumnType("bit");

                    b.HasKey("PrestationFK", "ClientFK", "DateRDv");

                    b.HasIndex("ClientFK");

                    b.ToTable("RDVS");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Prestation", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Prestataire", "Prestataire")
                        .WithMany("PrestationsList")
                        .HasForeignKey("PrestataireFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prestataire");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.RDV", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Client", "Client")
                        .WithMany("RDVList")
                        .HasForeignKey("ClientFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.ApplicationCore.Domain.Prestation", "Prestation")
                        .WithMany("rendezvouslist")
                        .HasForeignKey("PrestationFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Prestation");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Client", b =>
                {
                    b.Navigation("RDVList");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Prestataire", b =>
                {
                    b.Navigation("PrestationsList");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Prestation", b =>
                {
                    b.Navigation("rendezvouslist");
                });
#pragma warning restore 612, 618
        }
    }
}
