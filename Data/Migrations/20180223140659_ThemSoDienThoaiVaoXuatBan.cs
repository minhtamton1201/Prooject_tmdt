using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace QuanLyBanSach.Data.Migrations
{
    public partial class ThemSoDienThoaiVaoXuatBan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sach_ChuDe_ChuDeId",
                table: "Sach");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_DanhMuc_DanhMucId",
                table: "Sach");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_NhaXuatBan_NhaXuatBanId",
                table: "Sach");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TacGia_TacGiaId",
                table: "Sach");

            migrationBuilder.AlterColumn<int>(
                name: "TacGiaId",
                table: "Sach",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NhaXuatBanId",
                table: "Sach",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DanhMucId",
                table: "Sach",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChuDeId",
                table: "Sach",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoDienThoai",
                table: "NhaXuatBan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_ChuDe_ChuDeId",
                table: "Sach",
                column: "ChuDeId",
                principalTable: "ChuDe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_DanhMuc_DanhMucId",
                table: "Sach",
                column: "DanhMucId",
                principalTable: "DanhMuc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_NhaXuatBan_NhaXuatBanId",
                table: "Sach",
                column: "NhaXuatBanId",
                principalTable: "NhaXuatBan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TacGia_TacGiaId",
                table: "Sach",
                column: "TacGiaId",
                principalTable: "TacGia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sach_ChuDe_ChuDeId",
                table: "Sach");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_DanhMuc_DanhMucId",
                table: "Sach");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_NhaXuatBan_NhaXuatBanId",
                table: "Sach");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TacGia_TacGiaId",
                table: "Sach");

            migrationBuilder.DropColumn(
                name: "SoDienThoai",
                table: "NhaXuatBan");

            migrationBuilder.AlterColumn<int>(
                name: "TacGiaId",
                table: "Sach",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NhaXuatBanId",
                table: "Sach",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DanhMucId",
                table: "Sach",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ChuDeId",
                table: "Sach",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_ChuDe_ChuDeId",
                table: "Sach",
                column: "ChuDeId",
                principalTable: "ChuDe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_DanhMuc_DanhMucId",
                table: "Sach",
                column: "DanhMucId",
                principalTable: "DanhMuc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_NhaXuatBan_NhaXuatBanId",
                table: "Sach",
                column: "NhaXuatBanId",
                principalTable: "NhaXuatBan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TacGia_TacGiaId",
                table: "Sach",
                column: "TacGiaId",
                principalTable: "TacGia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
