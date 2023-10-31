using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AeC_Teste.Data.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoBancoDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogErro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoException = table.Column<string>(type: "varchar(100)", nullable: false),
                    StackTrace = table.Column<string>(type: "varchar(1000)", nullable: false),
                    MensagemErro = table.Column<string>(type: "varchar(250)", nullable: false),
                    Endpoint = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataErro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogErro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrevisaoTempoAeroporto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodigoIcao = table.Column<string>(type: "varchar(10)", nullable: false),
                    AtualizadoEm = table.Column<string>(type: "varchar(100)", nullable: false),
                    PressaoAtmosferica = table.Column<int>(type: "int", nullable: false),
                    Visibilidade = table.Column<string>(type: "varchar(100)", nullable: false),
                    Vento = table.Column<int>(type: "int", nullable: false),
                    DirecaoVento = table.Column<int>(type: "int", nullable: false),
                    Umidade = table.Column<int>(type: "int", nullable: false),
                    Condicao = table.Column<string>(type: "varchar(20)", nullable: false),
                    CondicaoDescricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    Temperatura = table.Column<float>(type: "real", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrevisaoTempoAeroporto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrevisaoTempoCidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCidade = table.Column<int>(type: "int", nullable: false),
                    NomeCidade = table.Column<string>(type: "varchar(200)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", nullable: false),
                    DataPrevisao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Condicao = table.Column<string>(type: "varchar(50)", nullable: false),
                    TemperaturaMinima = table.Column<int>(type: "int", nullable: false),
                    TemperaturaMaxima = table.Column<int>(type: "int", nullable: false),
                    IndiceUV = table.Column<int>(type: "int", nullable: false),
                    DescricaoCondicao = table.Column<string>(type: "varchar(100)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrevisaoTempoCidade", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogErro");

            migrationBuilder.DropTable(
                name: "PrevisaoTempoAeroporto");

            migrationBuilder.DropTable(
                name: "PrevisaoTempoCidade");
        }
    }
}
