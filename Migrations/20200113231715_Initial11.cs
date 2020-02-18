using Microsoft.EntityFrameworkCore.Migrations;

namespace MeuHelp.Migrations
{
    public partial class Initial11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Physicalperson",
                type: "VARCHAR(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShippingwayId",
                table: "Physicalperson",
                type: "INT(4)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Physicalperson",
                type: "VARCHAR(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SaleschannelId",
                table: "Physicalperson",
                type: "INT(4)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Rg",
                table: "Physicalperson",
                type: "VARCHAR(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlanId",
                table: "Physicalperson",
                type: "INT(4)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "PlacaVeiculo",
                table: "Physicalperson",
                type: "VARCHAR(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Physicalperson",
                type: "VARCHAR(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeMae",
                table: "Physicalperson",
                type: "VARCHAR(90)",
                maxLength: 90,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Physicalperson",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(90)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModeloVeiculo",
                table: "Physicalperson",
                type: "VARCHAR(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Physicalperson",
                type: "VARCHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Physicalperson",
                type: "VARCHAR(13)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Physicalperson",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Physicalperson",
                type: "VARCHAR(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Physicalperson",
                type: "VARCHAR(6)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Physicalperson",
                type: "VARCHAR(14)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Physicalperson",
                type: "VARCHAR(8)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Physicalperson",
                type: "VARCHAR(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Physicalperson",
                type: "VARCHAR(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnoVeiculo",
                table: "Physicalperson",
                type: "VARCHAR(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShippingwayId",
                table: "Physicalperson",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT(4)");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SaleschannelId",
                table: "Physicalperson",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT(4)");

            migrationBuilder.AlterColumn<string>(
                name: "Rg",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlanId",
                table: "Physicalperson",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT(4)");

            migrationBuilder.AlterColumn<string>(
                name: "PlacaVeiculo",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeMae",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(90)",
                oldMaxLength: 90,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Physicalperson",
                type: "VARCHAR(90)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ModeloVeiculo",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(13)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(14)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnoVeiculo",
                table: "Physicalperson",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(4)",
                oldMaxLength: 4,
                oldNullable: true);
        }
    }
}
