using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class SliderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliderlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Resim = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliderlar", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "KategoriAdi", "Url" },
                values: new object[,]
                {
                    { 6, "Kategori 1", "kategori-1" },
                    { 7, "Kategori 2", "kategori-2" },
                    { 8, "Kategori 3", "kategori-3" },
                    { 9, "Kategori 4", "kategori-4" },
                    { 10, "Kategori 5", "kategori-5" }
                });

            migrationBuilder.InsertData(
                table: "Sliderlar",
                columns: new[] { "Id", "Resim" },
                values: new object[,]
                {
                    { 1, "slider-1.jpeg" },
                    { 2, "slider-2.jpeg" },
                    { 3, "slider-3.jpeg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliderlar");

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
