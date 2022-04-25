﻿// <auto-generated />
using ControleContatos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleContatos.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ControleContatos.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasColumnName("Celular");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("CONTATO");
                });
#pragma warning restore 612, 618
        }
    }
}
