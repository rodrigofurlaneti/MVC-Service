using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeuHelp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Saleschannel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saleschannel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shippingway",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippingway", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Typeservice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typeservice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Physicalperson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    NomeMae = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    ShippingwayId = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    PlacaVeiculo = table.Column<string>(nullable: true),
                    AnoVeiculo = table.Column<string>(nullable: true),
                    ModeloVeiculo = table.Column<string>(nullable: true),
                    DataPagamento = table.Column<string>(nullable: true),
                    PlanId = table.Column<int>(nullable: false),
                    InicioVigencia = table.Column<string>(nullable: true),
                    FimVigencia = table.Column<string>(nullable: true),
                    DataVenda = table.Column<string>(nullable: true),
                    DataVencimentoAdesao = table.Column<string>(nullable: true),
                    DataAdesao = table.Column<string>(nullable: true),
                    SaleschannelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Physicalperson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Physicalperson_Plan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Physicalperson_Saleschannel_SaleschannelId",
                        column: x => x.SaleschannelId,
                        principalTable: "Saleschannel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Physicalperson_Shippingway_ShippingwayId",
                        column: x => x.ShippingwayId,
                        principalTable: "Shippingway",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Legalperson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cnpj = table.Column<string>(nullable: true),
                    RazaoSocial = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    DataVencimento = table.Column<string>(nullable: true),
                    ValorContrato = table.Column<string>(nullable: true),
                    InicioVigencia = table.Column<string>(nullable: true),
                    FimVigencia = table.Column<string>(nullable: true),
                    TypeserviceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legalperson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Legalperson_Typeservice_TypeserviceId",
                        column: x => x.TypeserviceId,
                        principalTable: "Typeservice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Collaborator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    LegalpersonId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    NomeMae = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    ShippingwayId = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    PlacaVeiculo = table.Column<string>(nullable: true),
                    AnoVeiculo = table.Column<string>(nullable: true),
                    ModeloVeiculo = table.Column<string>(nullable: true),
                    DataPagamento = table.Column<string>(nullable: true),
                    PlanId = table.Column<int>(nullable: false),
                    InicioVigencia = table.Column<string>(nullable: true),
                    FimVigencia = table.Column<string>(nullable: true),
                    DataVenda = table.Column<string>(nullable: true),
                    DataVencimentoAdesao = table.Column<string>(nullable: true),
                    DataAdesao = table.Column<string>(nullable: true),
                    SaleschannelId = table.Column<int>(nullable: false),
                    Conta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collaborator_Legalperson_LegalpersonId",
                        column: x => x.LegalpersonId,
                        principalTable: "Legalperson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Collaborator_Plan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Collaborator_Saleschannel_SaleschannelId",
                        column: x => x.SaleschannelId,
                        principalTable: "Saleschannel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Collaborator_Shippingway_ShippingwayId",
                        column: x => x.ShippingwayId,
                        principalTable: "Shippingway",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Collaborator_LegalpersonId",
                table: "Collaborator",
                column: "LegalpersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborator_PlanId",
                table: "Collaborator",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborator_SaleschannelId",
                table: "Collaborator",
                column: "SaleschannelId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborator_ShippingwayId",
                table: "Collaborator",
                column: "ShippingwayId");

            migrationBuilder.CreateIndex(
                name: "IX_Legalperson_TypeserviceId",
                table: "Legalperson",
                column: "TypeserviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Physicalperson_PlanId",
                table: "Physicalperson",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Physicalperson_SaleschannelId",
                table: "Physicalperson",
                column: "SaleschannelId");

            migrationBuilder.CreateIndex(
                name: "IX_Physicalperson_ShippingwayId",
                table: "Physicalperson",
                column: "ShippingwayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Collaborator");

            migrationBuilder.DropTable(
                name: "Physicalperson");

            migrationBuilder.DropTable(
                name: "Legalperson");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "Saleschannel");

            migrationBuilder.DropTable(
                name: "Shippingway");

            migrationBuilder.DropTable(
                name: "Typeservice");
        }
    }
}
