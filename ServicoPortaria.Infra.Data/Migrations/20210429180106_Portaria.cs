﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServicoPortaria.Infra.Data.Migrations
{
    public partial class Portaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Condominio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condominio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelDeAcesso = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fixo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Morador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fixo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCondominio = table.Column<int>(type: "int", nullable: false),
                    CondominioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Morador_Condominio_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Predio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    IdCondominio = table.Column<int>(type: "int", nullable: false),
                    CondominioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Predio_Condominio_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecuperacaoSenha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecuperacaoSenha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecuperacaoSenha_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Apartamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    IdMorador = table.Column<int>(type: "int", nullable: false),
                    IdPredio = table.Column<int>(type: "int", nullable: false),
                    IdCondominio = table.Column<int>(type: "int", nullable: false),
                    MoradorId = table.Column<int>(type: "int", nullable: true),
                    PredioId = table.Column<int>(type: "int", nullable: true),
                    CondominioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartamento_Condominio_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Apartamento_Morador_MoradorId",
                        column: x => x.MoradorId,
                        principalTable: "Morador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Apartamento_Predio_PredioId",
                        column: x => x.PredioId,
                        principalTable: "Predio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Garagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPredio = table.Column<int>(type: "int", nullable: false),
                    IdCondominio = table.Column<int>(type: "int", nullable: false),
                    PredioId = table.Column<int>(type: "int", nullable: true),
                    CondominioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Garagem_Condominio_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Garagem_Predio_PredioId",
                        column: x => x.PredioId,
                        principalTable: "Predio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrestadorServicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPredio = table.Column<int>(type: "int", nullable: false),
                    IdCondominio = table.Column<int>(type: "int", nullable: false),
                    PredioId = table.Column<int>(type: "int", nullable: true),
                    CondominioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestadorServicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrestadorServicos_Condominio_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrestadorServicos_Predio_PredioId",
                        column: x => x.PredioId,
                        principalTable: "Predio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sindico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPredio = table.Column<int>(type: "int", nullable: false),
                    IdCondominio = table.Column<int>(type: "int", nullable: false),
                    PredioId = table.Column<int>(type: "int", nullable: true),
                    CondominioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sindico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sindico_Condominio_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sindico_Predio_PredioId",
                        column: x => x.PredioId,
                        principalTable: "Predio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMorador = table.Column<int>(type: "int", nullable: false),
                    IdPredio = table.Column<int>(type: "int", nullable: false),
                    IdCondominio = table.Column<int>(type: "int", nullable: false),
                    MoradorId = table.Column<int>(type: "int", nullable: true),
                    PredioId = table.Column<int>(type: "int", nullable: true),
                    CondominioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculo_Condominio_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculo_Morador_MoradorId",
                        column: x => x.MoradorId,
                        principalTable: "Morador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculo_Predio_PredioId",
                        column: x => x.PredioId,
                        principalTable: "Predio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVisitante = table.Column<int>(type: "int", nullable: false),
                    IdMorador = table.Column<int>(type: "int", nullable: false),
                    Chegada = table.Column<TimeSpan>(type: "time", nullable: false),
                    Saida = table.Column<TimeSpan>(type: "time", nullable: false),
                    IdCondominio = table.Column<int>(type: "int", nullable: false),
                    IdPredio = table.Column<int>(type: "int", nullable: false),
                    IdApartamento = table.Column<int>(type: "int", nullable: false),
                    CondominioId = table.Column<int>(type: "int", nullable: true),
                    PredioId = table.Column<int>(type: "int", nullable: true),
                    ApartamentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visita_Apartamento_ApartamentoId",
                        column: x => x.ApartamentoId,
                        principalTable: "Apartamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visita_Condominio_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visita_Predio_PredioId",
                        column: x => x.PredioId,
                        principalTable: "Predio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartamento_CondominioId",
                table: "Apartamento",
                column: "CondominioId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartamento_MoradorId",
                table: "Apartamento",
                column: "MoradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartamento_PredioId",
                table: "Apartamento",
                column: "PredioId");

            migrationBuilder.CreateIndex(
                name: "IX_Garagem_CondominioId",
                table: "Garagem",
                column: "CondominioId");

            migrationBuilder.CreateIndex(
                name: "IX_Garagem_PredioId",
                table: "Garagem",
                column: "PredioId");

            migrationBuilder.CreateIndex(
                name: "IX_Morador_CondominioId",
                table: "Morador",
                column: "CondominioId");

            migrationBuilder.CreateIndex(
                name: "IX_Predio_CondominioId",
                table: "Predio",
                column: "CondominioId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestadorServicos_CondominioId",
                table: "PrestadorServicos",
                column: "CondominioId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestadorServicos_PredioId",
                table: "PrestadorServicos",
                column: "PredioId");

            migrationBuilder.CreateIndex(
                name: "IX_RecuperacaoSenha_UsuarioId",
                table: "RecuperacaoSenha",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Sindico_CondominioId",
                table: "Sindico",
                column: "CondominioId");

            migrationBuilder.CreateIndex(
                name: "IX_Sindico_PredioId",
                table: "Sindico",
                column: "PredioId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_CondominioId",
                table: "Veiculo",
                column: "CondominioId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_MoradorId",
                table: "Veiculo",
                column: "MoradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_PredioId",
                table: "Veiculo",
                column: "PredioId");

            migrationBuilder.CreateIndex(
                name: "IX_Visita_ApartamentoId",
                table: "Visita",
                column: "ApartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Visita_CondominioId",
                table: "Visita",
                column: "CondominioId");

            migrationBuilder.CreateIndex(
                name: "IX_Visita_PredioId",
                table: "Visita",
                column: "PredioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garagem");

            migrationBuilder.DropTable(
                name: "PrestadorServicos");

            migrationBuilder.DropTable(
                name: "RecuperacaoSenha");

            migrationBuilder.DropTable(
                name: "Sindico");

            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Visita");

            migrationBuilder.DropTable(
                name: "Visitante");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Apartamento");

            migrationBuilder.DropTable(
                name: "Morador");

            migrationBuilder.DropTable(
                name: "Predio");

            migrationBuilder.DropTable(
                name: "Condominio");
        }
    }
}