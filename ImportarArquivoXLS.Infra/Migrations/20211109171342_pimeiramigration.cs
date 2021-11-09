using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportarArquivoXLS.Infra.Migrations
{
    public partial class pimeiramigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DadosDaPlanilha",
                columns: table => new
                {
                    PagamentoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Credor = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    DocumentoCredor = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    NumeroProcesso = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    Finalidade = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    ValorPago = table.Column<string>(type: "nvarchar(max)", precision: 18, scale: 2, nullable: false),
                    Movimentacao = table.Column<string>(type: "nvarchar(max)", precision: 18, scale: 2, nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CpfCnpjCessionario = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    Cessionario = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosDaPlanilha", x => x.PagamentoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadosDaPlanilha");
        }
    }
}
