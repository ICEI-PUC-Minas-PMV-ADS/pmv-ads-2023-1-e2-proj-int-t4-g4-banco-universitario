using Microsoft.EntityFrameworkCore.Migrations;

namespace AppDescontoUniver.Migrations
{
    public partial class M02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumos_Empresas_EmpresaId",
                table: "Consumos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consumos",
                table: "Consumos");

            migrationBuilder.RenameTable(
                name: "Consumos",
                newName: "Produtos");

            migrationBuilder.RenameIndex(
                name: "IX_Consumos_EmpresaId",
                table: "Produtos",
                newName: "IX_Produtos_EmpresaId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Produtos",
                type: "decimal (18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Empresas_EmpresaId",
                table: "Produtos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Empresas_EmpresaId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "Consumos");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_EmpresaId",
                table: "Consumos",
                newName: "IX_Consumos_EmpresaId");

            migrationBuilder.AlterColumn<double>(
                name: "Preco",
                table: "Consumos",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal (18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consumos",
                table: "Consumos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumos_Empresas_EmpresaId",
                table: "Consumos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
