using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace QuanLyBanSach.Data.Migrations
{
    public partial class ThemNgayGiaoVaoHoaDon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "HoaDon");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayGiao",
                table: "HoaDon",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayGiao",
                table: "HoaDon");

            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "HoaDon",
                nullable: false,
                defaultValue: false);
        }
    }
}
