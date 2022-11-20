﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoAllAccess.Data;

#nullable disable

namespace ProjetoAllAccess.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoAllAccess.Models.PageExercicioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Assunto")
                        .HasColumnType("longtext");

                    b.Property<string>("Conteudo")
                        .HasColumnType("longtext");

                    b.Property<string>("Materia")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Exercicio");
                });

            modelBuilder.Entity("ProjetoAllAccess.Models.PageModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Assunto")
                        .HasColumnType("longtext");

                    b.Property<string>("Conteudo")
                        .HasColumnType("longtext");

                    b.Property<string>("Materia")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Conteudos");
                });

            modelBuilder.Entity("ProjetoAllAccess.Models.PostUserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Materia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PostUser");
                });

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

            modelBuilder.Entity("ProjetoAllAccess.Models.VestibularModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Conteudo")
                        .HasColumnType("longtext");

                    b.Property<string>("Materia")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeVest")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ExVest");
                });
#pragma warning restore 612, 618
        }
    }
}
