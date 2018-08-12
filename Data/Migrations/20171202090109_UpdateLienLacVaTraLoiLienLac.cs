using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace QuanLyBanSach.Data.Migrations
{
    public partial class UpdateLienLacVaTraLoiLienLac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LienLac_TraLoiLienLac_traLoiLienLacId",
                table: "LienLac");

            migrationBuilder.DropIndex(
                name: "IX_LienLac_traLoiLienLacId",
                table: "LienLac");

            migrationBuilder.DropColumn(
                name: "traLoiLienLacId",
                table: "LienLac");

            migrationBuilder.AddColumn<int>(
                name: "LienLacId",
                table: "TraLoiLienLac",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayGoi",
                table: "LienLac",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_TraLoiLienLac_LienLacId",
                table: "TraLoiLienLac",
                column: "LienLacId");

            migrationBuilder.AddForeignKey(
                name: "FK_TraLoiLienLac_LienLac_LienLacId",
                table: "TraLoiLienLac",
                column: "LienLacId",
                principalTable: "LienLac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TraLoiLienLac_LienLac_LienLacId",
                table: "TraLoiLienLac");

            migrationBuilder.DropIndex(
                name: "IX_TraLoiLienLac_LienLacId",
                table: "TraLoiLienLac");

            migrationBuilder.DropColumn(
                name: "LienLacId",
                table: "TraLoiLienLac");

            migrationBuilder.DropColumn(
                name: "NgayGoi",
                table: "LienLac");

            migrationBuilder.AddColumn<int>(
                name: "traLoiLienLacId",
                table: "LienLac",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LienLac_traLoiLienLacId",
                table: "LienLac",
                column: "traLoiLienLacId",
                unique: true,
                filter: "[traLoiLienLacId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_LienLac_TraLoiLienLac_traLoiLienLacId",
                table: "LienLac",
                column: "traLoiLienLacId",
                principalTable: "TraLoiLienLac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
