using Microsoft.EntityFrameworkCore.Migrations;

namespace MySallers.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoVendas_Vendedor_VendedorId",
                table: "HistoricoVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Departamento_DepartamentoId",
                table: "Vendedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendedor",
                table: "Vendedor");

            migrationBuilder.RenameTable(
                name: "Vendedor",
                newName: "Vendedores");

            migrationBuilder.RenameIndex(
                name: "IX_Vendedor_DepartamentoId",
                table: "Vendedores",
                newName: "IX_Vendedores_DepartamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendedores",
                table: "Vendedores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoVendas_Vendedores_VendedorId",
                table: "HistoricoVendas",
                column: "VendedorId",
                principalTable: "Vendedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedores_Departamento_DepartamentoId",
                table: "Vendedores",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoVendas_Vendedores_VendedorId",
                table: "HistoricoVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendedores_Departamento_DepartamentoId",
                table: "Vendedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendedores",
                table: "Vendedores");

            migrationBuilder.RenameTable(
                name: "Vendedores",
                newName: "Vendedor");

            migrationBuilder.RenameIndex(
                name: "IX_Vendedores_DepartamentoId",
                table: "Vendedor",
                newName: "IX_Vendedor_DepartamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendedor",
                table: "Vendedor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoVendas_Vendedor_VendedorId",
                table: "HistoricoVendas",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Departamento_DepartamentoId",
                table: "Vendedor",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
