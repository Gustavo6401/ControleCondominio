﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServicoPortaria.Infra.Data.Contexto;

namespace ServicoPortaria.Infra.Data.Migrations
{
    [DbContext(typeof(PortariaContext))]
    [Migration("20210429180106_Portaria")]
    partial class Portaria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Visita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApartamentoId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Chegada")
                        .HasColumnType("time");

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<int>("IdApartamento")
                        .HasColumnType("int");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<int>("IdMorador")
                        .HasColumnType("int");

                    b.Property<int>("IdPredio")
                        .HasColumnType("int");

                    b.Property<int>("IdVisitante")
                        .HasColumnType("int");

                    b.Property<int?>("PredioId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Saida")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ApartamentoId");

                    b.HasIndex("CondominioId");

                    b.HasIndex("PredioId");

                    b.ToTable("Visita");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Apartamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<int>("IdMorador")
                        .HasColumnType("int");

                    b.Property<int>("IdPredio")
                        .HasColumnType("int");

                    b.Property<int?>("MoradorId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int?>("PredioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.HasIndex("MoradorId");

                    b.HasIndex("PredioId");

                    b.ToTable("Apartamento");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Condominio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Condominio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Garagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<int>("IdPredio")
                        .HasColumnType("int");

                    b.Property<int?>("PredioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.HasIndex("PredioId");

                    b.ToTable("Garagem");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Morador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<string>("DocCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fixo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.ToTable("Morador");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Predio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.ToTable("Predio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.PrestadorSevicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<int>("IdPredio")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PredioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.HasIndex("PredioId");

                    b.ToTable("PrestadorServicos");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.RecuperacaoSenha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("RecuperacaoSenha");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Sindico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<string>("DocCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<int>("IdPredio")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PredioId")
                        .HasColumnType("int");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.HasIndex("PredioId");

                    b.ToTable("Sindico");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NivelDeAcesso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CondominioId")
                        .HasColumnType("int");

                    b.Property<int>("IdCondominio")
                        .HasColumnType("int");

                    b.Property<int>("IdMorador")
                        .HasColumnType("int");

                    b.Property<int>("IdPredio")
                        .HasColumnType("int");

                    b.Property<int?>("MoradorId")
                        .HasColumnType("int");

                    b.Property<int?>("PredioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CondominioId");

                    b.HasIndex("MoradorId");

                    b.HasIndex("PredioId");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Visitante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fixo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Visitante");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Entities.Visita", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Enttities.Apartamento", "Apartamento")
                        .WithMany()
                        .HasForeignKey("ApartamentoId");

                    b.HasOne("ServicoPortaria.Domain.Enttities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.HasOne("ServicoPortaria.Domain.Enttities.Predio", "Predio")
                        .WithMany()
                        .HasForeignKey("PredioId");

                    b.Navigation("Apartamento");

                    b.Navigation("Condominio");

                    b.Navigation("Predio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Apartamento", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Enttities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.HasOne("ServicoPortaria.Domain.Enttities.Morador", "Morador")
                        .WithMany()
                        .HasForeignKey("MoradorId");

                    b.HasOne("ServicoPortaria.Domain.Enttities.Predio", "Predio")
                        .WithMany()
                        .HasForeignKey("PredioId");

                    b.Navigation("Condominio");

                    b.Navigation("Morador");

                    b.Navigation("Predio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Garagem", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Enttities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.HasOne("ServicoPortaria.Domain.Enttities.Predio", "Predio")
                        .WithMany()
                        .HasForeignKey("PredioId");

                    b.Navigation("Condominio");

                    b.Navigation("Predio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Morador", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Enttities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.Navigation("Condominio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Predio", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Enttities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.Navigation("Condominio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.PrestadorSevicos", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Enttities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.HasOne("ServicoPortaria.Domain.Enttities.Predio", "Predio")
                        .WithMany()
                        .HasForeignKey("PredioId");

                    b.Navigation("Condominio");

                    b.Navigation("Predio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.RecuperacaoSenha", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Enttities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Sindico", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Enttities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.HasOne("ServicoPortaria.Domain.Enttities.Predio", "Predio")
                        .WithMany()
                        .HasForeignKey("PredioId");

                    b.Navigation("Condominio");

                    b.Navigation("Predio");
                });

            modelBuilder.Entity("ServicoPortaria.Domain.Enttities.Veiculo", b =>
                {
                    b.HasOne("ServicoPortaria.Domain.Enttities.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");

                    b.HasOne("ServicoPortaria.Domain.Enttities.Morador", "Morador")
                        .WithMany()
                        .HasForeignKey("MoradorId");

                    b.HasOne("ServicoPortaria.Domain.Enttities.Predio", "Predio")
                        .WithMany()
                        .HasForeignKey("PredioId");

                    b.Navigation("Condominio");

                    b.Navigation("Morador");

                    b.Navigation("Predio");
                });
#pragma warning restore 612, 618
        }
    }
}
