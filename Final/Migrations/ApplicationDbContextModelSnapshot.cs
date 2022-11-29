﻿// <auto-generated />
using System;
using Final.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Final.Models.Distrito", b =>
                {
                    b.Property<int>("codigo_distrito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("codigo_distrito"), 1L, 1);

                    b.Property<string>("nombre_distrito")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("codigo_distrito");

                    b.ToTable("Distritos");
                });

            modelBuilder.Entity("Final.Models.Proveedor", b =>
                {
                    b.Property<int>("cod_provedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cod_provedor"), 1L, 1);

                    b.Property<int?>("Distritoscodigo_distrito")
                        .HasColumnType("int");

                    b.Property<int>("codigo_distrito")
                        .HasColumnType("int");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("razonsocial")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("repartidor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("cod_provedor");

                    b.HasIndex("Distritoscodigo_distrito");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Final.Models.Proveedor", b =>
                {
                    b.HasOne("Final.Models.Distrito", "Distritos")
                        .WithMany()
                        .HasForeignKey("Distritoscodigo_distrito");

                    b.Navigation("Distritos");
                });
#pragma warning restore 612, 618
        }
    }
}
