﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WMVCADS2023.Models;

#nullable disable

namespace WMVCADS2023.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230823013124_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WMVCADS2023.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("aniversario")
                        .HasColumnType("datetime2");

                    b.Property<int>("cursoid")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("periodo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("cursoid");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("WMVCADS2023.Models.Atendimento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("alunoid")
                        .HasColumnType("int");

                    b.Property<DateTime>("data_hora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("salaid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("alunoid");

                    b.HasIndex("salaid");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("WMVCADS2023.Models.Curso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("WMVCADS2023.Models.Sala", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("equipamentos")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("id");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("WMVCADS2023.Models.Aluno", b =>
                {
                    b.HasOne("WMVCADS2023.Models.Curso", "curso")
                        .WithMany()
                        .HasForeignKey("cursoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("curso");
                });

            modelBuilder.Entity("WMVCADS2023.Models.Atendimento", b =>
                {
                    b.HasOne("WMVCADS2023.Models.Aluno", "aluno")
                        .WithMany()
                        .HasForeignKey("alunoid");

                    b.HasOne("WMVCADS2023.Models.Sala", "sala")
                        .WithMany()
                        .HasForeignKey("salaid");

                    b.Navigation("aluno");

                    b.Navigation("sala");
                });
#pragma warning restore 612, 618
        }
    }
}