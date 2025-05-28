using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUrunEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Urunler",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Anasayfa",
                table: "Urunler",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "Urunler",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet.", true, "1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet.", true, "2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet.", false, "3.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet.", true, "4.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet.", false, "5.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet.", false, "6.jpeg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "Anasayfa",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "Resim",
                table: "Urunler");
        }
    }
}
