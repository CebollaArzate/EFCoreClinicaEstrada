﻿// <auto-generated />
using System;
using EFCoreClinicaEstrada.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreClinicaEstrada.Data.Migrations
{
    [DbContext(typeof(FisioEstradaDbContext))]
    [Migration("20230426195726_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsultaTerapia", b =>
                {
                    b.Property<Guid>("ConsultasId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TerapiasId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ConsultasId", "TerapiasId");

                    b.HasIndex("TerapiasId");

                    b.ToTable("ConsultaTerapia");
                });

            modelBuilder.Entity("EFCoreClinicaEstrada.Domain.Entities.Consulta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ConDescuento")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ExpedienteClinicoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FisioTerapeutaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MotivoConsulta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("PorcentajeDescuento")
                        .HasColumnType("real");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Realizada")
                        .HasColumnType("bit");

                    b.Property<Guid>("SoapId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExpedienteClinicoId");

                    b.HasIndex("FisioTerapeutaId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("SoapId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("EFCoreClinicaEstrada.Domain.Entities.ExpedienteClinico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId")
                        .IsUnique();

                    b.ToTable("ExpedientesClinicos");
                });

            modelBuilder.Entity("EFCoreClinicaEstrada.Domain.Entities.NotaSoap", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Evaluacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Objetivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subjetivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NotasSoap");
                });

            modelBuilder.Entity("EFCoreClinicaEstrada.Domain.Entities.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("EFCoreClinicaEstrada.Domain.Entities.Terapeuta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CedulaProfesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RFC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Terapeutas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4e4db7de-5981-48f0-8637-9f0c1e14465b"),
                            CedulaProfesional = "12345678",
                            Celular = "7331525813",
                            FechaIngreso = new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            FechaNacimiento = new DateTime(1993, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Kevin David Estrada Posada",
                            RFC = "EAPK930905QD7",
                            Titulo = "Lic. Fisioterapeuta"
                        },
                        new
                        {
                            Id = new Guid("426ac8d5-7253-450f-8480-5981de63c30f"),
                            CedulaProfesional = "87654321",
                            Celular = "7331251176",
                            FechaIngreso = new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            FechaNacimiento = new DateTime(1965, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "David Estrada Aguilar",
                            RFC = "EAAD651015AKA",
                            Titulo = "Lic. Fisioterapeuta"
                        });
                });

            modelBuilder.Entity("EFCoreClinicaEstrada.Domain.Entities.Terapia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Terapias");

                    b.HasData(
                        new
                        {
                            Id = new Guid("df8d035a-dfac-4e0a-906b-2ca18544b7b8"),
                            Nombre = "Electro Introacticula"
                        },
                        new
                        {
                            Id = new Guid("a6a0797c-f23a-40db-a48c-56c616be22d1"),
                            Nombre = "Fortalecimiento"
                        },
                        new
                        {
                            Id = new Guid("9719183b-7cb7-491d-b32b-e2351dcd5bd3"),
                            Nombre = "Movilidad"
                        },
                        new
                        {
                            Id = new Guid("ff8ec6d0-eb58-42ad-ada5-81acb1f71653"),
                            Nombre = "Recuperacion Activa"
                        },
                        new
                        {
                            Id = new Guid("c4645e94-0352-4024-be6f-0324301cb878"),
                            Nombre = "Bicicleta"
                        });
                });

            modelBuilder.Entity("ConsultaTerapia", b =>
                {
                    b.HasOne("EFCoreClinicaEstrada.Domain.Entities.Consulta", null)
                        .WithMany()
                        .HasForeignKey("ConsultasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreClinicaEstrada.Domain.Entities.Terapia", null)
                        .WithMany()
                        .HasForeignKey("TerapiasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreClinicaEstrada.Domain.Entities.Consulta", b =>
                {
                    b.HasOne("EFCoreClinicaEstrada.Domain.Entities.ExpedienteClinico", null)
                        .WithMany("Consultas")
                        .HasForeignKey("ExpedienteClinicoId");

                    b.HasOne("EFCoreClinicaEstrada.Domain.Entities.Terapeuta", "FisioTerapeuta")
                        .WithMany()
                        .HasForeignKey("FisioTerapeutaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreClinicaEstrada.Domain.Entities.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreClinicaEstrada.Domain.Entities.NotaSoap", "Soap")
                        .WithMany()
                        .HasForeignKey("SoapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FisioTerapeuta");

                    b.Navigation("Paciente");

                    b.Navigation("Soap");
                });

            modelBuilder.Entity("EFCoreClinicaEstrada.Domain.Entities.ExpedienteClinico", b =>
                {
                    b.HasOne("EFCoreClinicaEstrada.Domain.Entities.Paciente", "Paciente")
                        .WithOne("Expediente")
                        .HasForeignKey("EFCoreClinicaEstrada.Domain.Entities.ExpedienteClinico", "PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("EFCoreClinicaEstrada.Domain.Entities.ExpedienteClinico", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("EFCoreClinicaEstrada.Domain.Entities.Paciente", b =>
                {
                    b.Navigation("Expediente")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
