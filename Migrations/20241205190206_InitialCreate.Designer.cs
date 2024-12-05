﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProjectISO.Data;

#nullable disable

namespace ProjectISO.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241205190206_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProjectISO.Models.Activo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CuentaCompra")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CuentaDepresiacion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("integer");

                    b.Property<double>("DepresiacionAcumulada")
                        .HasColumnType("double precision");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("FechaRegistro")
                        .HasColumnType("date");

                    b.Property<double>("TiempoDepresiacion")
                        .HasColumnType("double precision");

                    b.Property<double>("ValorCompra")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Activo");
                });

            modelBuilder.Entity("ProjectISO.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("ProjectISO.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("integer");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("FechaIngreso")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("TipoPersona")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("ProjectISO.Models.TipoDeActivo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("ActivoId")
                        .HasColumnType("integer");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ActivoId")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("TipoDeActivos");
                });

            modelBuilder.Entity("ProjectISO.Models.Activo", b =>
                {
                    b.HasOne("ProjectISO.Models.Departamento", "Departamento")
                        .WithMany("Activos")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("ProjectISO.Models.Empleado", b =>
                {
                    b.HasOne("ProjectISO.Models.Departamento", "Departamento")
                        .WithMany("Empleados")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("ProjectISO.Models.TipoDeActivo", b =>
                {
                    b.HasOne("ProjectISO.Models.Activo", "Activo")
                        .WithOne("TipoDeActivo")
                        .HasForeignKey("ProjectISO.Models.TipoDeActivo", "ActivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activo");
                });

            modelBuilder.Entity("ProjectISO.Models.Activo", b =>
                {
                    b.Navigation("TipoDeActivo")
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectISO.Models.Departamento", b =>
                {
                    b.Navigation("Activos");

                    b.Navigation("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}