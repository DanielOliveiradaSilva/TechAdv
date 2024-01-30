﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechAdv.Infrastructure.Context;

#nullable disable

namespace TechAdv.Infrastructure.Migrations
{
    [DbContext(typeof(TechAdvContext))]
    partial class TechAdvContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TechAdv.Core.Entities.Advogado", b =>
                {
                    b.Property<int>("AdvogadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CNA")
                        .HasColumnType("longtext");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<int>("CasoJuridicoId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("AdvogadoId");

                    b.ToTable("Advogados", (string)null);
                });

            modelBuilder.Entity("TechAdv.Core.Entities.CasoJuridico", b =>
                {
                    b.Property<int>("CasoJuridicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Abertura")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("AdvogadoId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId1")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("Encerramento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CasoJuridicoId");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.HasIndex("ClienteId1");

                    b.ToTable("CasoJuridicos", (string)null);
                });

            modelBuilder.Entity("TechAdv.Core.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Profissao")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("TechAdv.Core.Entities.Documento", b =>
                {
                    b.Property<int>("DocumentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CasoJuridicoId")
                        .HasColumnType("int");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("DocumentoId");

                    b.HasIndex("CasoJuridicoId");

                    b.ToTable("Documentos", (string)null);
                });

            modelBuilder.Entity("TechAdv.Core.Entities.CasoJuridico", b =>
                {
                    b.HasOne("TechAdv.Core.Entities.Advogado", "Advogado")
                        .WithOne("CasoJuridico")
                        .HasForeignKey("TechAdv.Core.Entities.CasoJuridico", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechAdv.Core.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advogado");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("TechAdv.Core.Entities.Documento", b =>
                {
                    b.HasOne("TechAdv.Core.Entities.CasoJuridico", "CasoJuridico")
                        .WithMany("Documentos")
                        .HasForeignKey("CasoJuridicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CasoJuridico");
                });

            modelBuilder.Entity("TechAdv.Core.Entities.Advogado", b =>
                {
                    b.Navigation("CasoJuridico");
                });

            modelBuilder.Entity("TechAdv.Core.Entities.CasoJuridico", b =>
                {
                    b.Navigation("Documentos");
                });
#pragma warning restore 612, 618
        }
    }
}
