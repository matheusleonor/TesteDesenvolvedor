﻿// <auto-generated />
using CadastroMotorista.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CadastroMotorista.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20201126175447_CriacaoBD")]
    partial class CriacaoBD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CadastroMotorista.Models.Motorista", b =>
                {
                    b.Property<int>("MotoristaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Eixos");

                    b.Property<string>("Endereco");

                    b.Property<string>("Marca");

                    b.Property<string>("Modelo");

                    b.Property<string>("Nome");

                    b.Property<string>("Placa");

                    b.Property<string>("SobreNome");

                    b.HasKey("MotoristaId");

                    b.ToTable("Motoristas");
                });
#pragma warning restore 612, 618
        }
    }
}