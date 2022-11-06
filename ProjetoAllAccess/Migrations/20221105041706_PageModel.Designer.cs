﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoAllAccess.Data;

#nullable disable

namespace ProjetoAllAccess.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221105041706_PageModel")]
    partial class PageModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoAllAccess.Models.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Email");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("Nascimento");

                    b.Property<int>("Nivel")
                        .HasColumnType("int")
                        .HasColumnName("Nivel");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Senha");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Sobrenome");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
