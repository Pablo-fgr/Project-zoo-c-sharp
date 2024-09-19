﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PAV_TPFinal_56340_Infraestructura_Datos;

#nullable disable

namespace PAV_TPFinal_56340_Infraestructura_Datos.Migrations
{
    [DbContext(typeof(PavTpFinalContext))]
    [Migration("20240723151541_Modelo-Inicial-Datos")]
    partial class ModeloInicialDatos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PAV_TPFinal_56340_Dominio.Entidades.Animal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<Guid>("EspecieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PaisId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<Guid>("SectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TipoAlimentacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EspecieId");

                    b.HasIndex("PaisId");

                    b.HasIndex("SectorId");

                    b.ToTable("Animales", (string)null);

                    b.HasDiscriminator<int>("TipoAlimentacion");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("PAV_TPFinal_56340_Dominio.Entidades.Empleado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Empleados", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3e45eb64-d60e-49a0-8731-f8bb1962ff3d"),
                            Dni = "12345678",
                            Domicilio = "Tucumán",
                            Nombre = "Luis"
                        },
                        new
                        {
                            Id = new Guid("f2208f6b-9e57-4cf1-87ff-91957be8e699"),
                            Dni = "87654321",
                            Domicilio = "Tucumán",
                            Nombre = "María"
                        });
                });

            modelBuilder.Entity("PAV_TPFinal_56340_Dominio.Entidades.Especie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("PorcentajePesoCarne")
                        .HasColumnType("float");

                    b.Property<int>("TipoAlimentacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Especies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ea9dea9d-92ca-43be-bf7c-fe257b8dbdfb"),
                            Codigo = 1,
                            Nombre = "León",
                            PorcentajePesoCarne = 0.69999999999999996,
                            TipoAlimentacion = 0
                        },
                        new
                        {
                            Id = new Guid("c19e408a-d9e0-4d2c-8ef2-913b4a21f327"),
                            Codigo = 2,
                            Nombre = "Jirafa",
                            PorcentajePesoCarne = 0.0,
                            TipoAlimentacion = 1
                        },
                        new
                        {
                            Id = new Guid("c94eb08b-7268-4f9b-b64c-78ce32efb358"),
                            Codigo = 3,
                            Nombre = "Tigre",
                            PorcentajePesoCarne = 0.5,
                            TipoAlimentacion = 0
                        },
                        new
                        {
                            Id = new Guid("05c85532-133f-47df-9ef3-8c6f979c6bdd"),
                            Codigo = 4,
                            Nombre = "Rinoceronte",
                            PorcentajePesoCarne = 0.0,
                            TipoAlimentacion = 1
                        });
                });

            modelBuilder.Entity("PAV_TPFinal_56340_Dominio.Entidades.Pais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Paises", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("573d1328-176a-4398-b43d-a60b3ddf7f43"),
                            Codigo = 1,
                            Nombre = "Australia"
                        },
                        new
                        {
                            Id = new Guid("cffb2f99-8072-48b4-8e48-61696cb83842"),
                            Codigo = 2,
                            Nombre = "Canadá"
                        },
                        new
                        {
                            Id = new Guid("bc4d6cf0-30ad-4b09-9e35-539942c9e59e"),
                            Codigo = 3,
                            Nombre = "Singapur"
                        },
                        new
                        {
                            Id = new Guid("be8c440c-a689-4cb9-9ad8-a8cd9dc18970"),
                            Codigo = 4,
                            Nombre = "Sudáfrica"
                        });
                });

            modelBuilder.Entity("PAV_TPFinal_56340_Dominio.Entidades.Sector", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmpleadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Latitud")
                        .HasPrecision(10, 8)
                        .HasColumnType("float(10)");

                    b.Property<int>("Limite")
                        .HasColumnType("int");

                    b.Property<double>("Longitud")
                        .HasPrecision(10, 8)
                        .HasColumnType("float(10)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("TipoAlimentacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Sectores", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3e564cbc-225a-49e4-a1da-043b53b8ec1d"),
                            EmpleadoId = new Guid("3e45eb64-d60e-49a0-8731-f8bb1962ff3d"),
                            Latitud = -26.250724000000002,
                            Limite = 10,
                            Longitud = -65.522827000000007,
                            Numero = 1,
                            TipoAlimentacion = 1
                        },
                        new
                        {
                            Id = new Guid("1c23e32a-2b66-4689-a70c-9899afde5658"),
                            EmpleadoId = new Guid("3e45eb64-d60e-49a0-8731-f8bb1962ff3d"),
                            Latitud = -26.252358999999998,
                            Limite = 10,
                            Longitud = -65.521511000000004,
                            Numero = 2,
                            TipoAlimentacion = 0
                        },
                        new
                        {
                            Id = new Guid("5a334e17-193a-4cab-a485-27acb30bb671"),
                            EmpleadoId = new Guid("f2208f6b-9e57-4cf1-87ff-91957be8e699"),
                            Latitud = -26.254660999999999,
                            Limite = 10,
                            Longitud = -65.522726000000006,
                            Numero = 3,
                            TipoAlimentacion = 1
                        },
                        new
                        {
                            Id = new Guid("60514f2b-bed5-4835-a13f-cf6cbe5ca5c4"),
                            EmpleadoId = new Guid("f2208f6b-9e57-4cf1-87ff-91957be8e699"),
                            Latitud = -26.257249999999999,
                            Limite = 10,
                            Longitud = -65.523514000000006,
                            Numero = 4,
                            TipoAlimentacion = 0
                        });
                });

            modelBuilder.Entity("PAV_TPFinal_56340_Dominio.Entidades.Carnivoro", b =>
                {
                    b.HasBaseType("PAV_TPFinal_56340_Dominio.Entidades.Animal");

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("PAV_TPFinal_56340_Dominio.Entidades.Herbivoro", b =>
                {
                    b.HasBaseType("PAV_TPFinal_56340_Dominio.Entidades.Animal");

                    b.Property<double>("ValorFijo")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("PAV_TPFinal_56340_Dominio.Entidades.Animal", b =>
                {
                    b.HasOne("PAV_TPFinal_56340_Dominio.Entidades.Especie", "Especie")
                        .WithMany()
                        .HasForeignKey("EspecieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PAV_TPFinal_56340_Dominio.Entidades.Pais", "PaisOrigen")
                        .WithMany()
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PAV_TPFinal_56340_Dominio.Entidades.Sector", "Sector")
                        .WithMany("Animales")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especie");

                    b.Navigation("PaisOrigen");

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("PAV_TPFinal_56340_Dominio.Entidades.Sector", b =>
                {
                    b.HasOne("PAV_TPFinal_56340_Dominio.Entidades.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("PAV_TPFinal_56340_Dominio.Entidades.Sector", b =>
                {
                    b.Navigation("Animales");
                });
#pragma warning restore 612, 618
        }
    }
}
