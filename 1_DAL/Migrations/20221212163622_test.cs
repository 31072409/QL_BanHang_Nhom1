using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet",
                columns: new[] { "IdSP", "IdHD" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet",
                column: "IdSP");
        }
    }
}
