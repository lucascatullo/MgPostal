using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MgPostal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Envios",
                columns: table => new
                {
                    EnvioId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Remito = table.Column<string>(nullable: false),
                    Fecha = table.Column<string>(nullable: false),
                    Destinatario = table.Column<string>(nullable: false),
                    Calle = table.Column<string>(nullable: false),
                    NumeroCalle = table.Column<string>(nullable: false),
                    Piso = table.Column<string>(nullable: true),
                    Localidad_Destino = table.Column<string>(nullable: false),
                    Remitente = table.Column<string>(nullable: false),
                    Direccion_Remitente = table.Column<string>(nullable: false),
                    Forma_Pago = table.Column<string>(nullable: false),
                    Bultos = table.Column<int>(nullable: false),
                    Valor_Declarado = table.Column<decimal>(nullable: false),
                    Observaciones = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envios", x => x.EnvioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Envios");
        }
    }
}
