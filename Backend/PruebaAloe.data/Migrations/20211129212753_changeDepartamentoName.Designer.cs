﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaAloe.data;

namespace PruebaAloe.data.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211129212753_changeDepartamentoName")]
    partial class changeDepartamentoName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PruebaAloe.core.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departamento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "DPT-01",
                            Nombre = "Departamento de ventas"
                        },
                        new
                        {
                            Id = 2,
                            Codigo = "DPT-02",
                            Nombre = "Departamento de Compras"
                        });
                });

            modelBuilder.Entity("PruebaAloe.core.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SupervisorInmediatoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("SupervisorInmediatoId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("PruebaAloe.core.Usuario", b =>
                {
                    b.HasOne("PruebaAloe.core.Departamento", "Departamento")
                        .WithMany("Usuarios")
                        .HasForeignKey("DepartamentoId");

                    b.HasOne("PruebaAloe.core.Usuario", "SupervisorInmediato")
                        .WithMany()
                        .HasForeignKey("SupervisorInmediatoId");

                    b.Navigation("Departamento");

                    b.Navigation("SupervisorInmediato");
                });

            modelBuilder.Entity("PruebaAloe.core.Departamento", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
