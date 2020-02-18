using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeuHelp.Migrations
{
    public partial class Initial14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataPagamento",
                table: "Physicalperson",
                type: "VARCHAR(4)",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataPagamento",
                table: "Physicalperson",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(4)",
                oldNullable: true);
        }
    }
}
