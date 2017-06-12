using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace LojaComEntity.Migrations
{
    public partial class AlterProdutoDropColumnIdCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Produto_Categoria_CategoriaId", table: "Produto");
            migrationBuilder.DropColumn(name: "IdCategoria", table: "Produto");
            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Produto",
                nullable: false);
            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Produto_Categoria_CategoriaId", table: "Produto");
            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Produto",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "IdCategoria",
                table: "Produto",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
