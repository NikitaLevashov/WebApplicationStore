using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationStoreDAL.Migrations
{
    public partial class AddProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mobile phone" },
                    { 2, "Notebook" },
                    { 3, "Camera" },
                    { 4, "Headphones" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CatalogID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Xiaomi Redmi Note 8" },
                    { 23, 4, "Xiaomi Dual Driver Earphones (черный)" },
                    { 22, 4, "Xiaomi Mi In-Ear Pro HD" },
                    { 21, 4, "Xiaomi Mi True Wireless Earphones 2 TWSEJ06WM" },
                    { 20, 4, "Xiaomi Mi True Wireless Earphones Lite TWSEJ03WM" },
                    { 19, 4, "Xiaomi Mi True Wireless Earbuds Basic 2 TWSEJ061LS°" },
                    { 18, 3, "Xiaomi XiaoFang 1080p" },
                    { 17, 3, "Xiaomi Dafang PTZ 1080p" },
                    { 16, 3, "Xiaomi Mi Home Security Camera Basic" },
                    { 15, 3, "Xiaomi MiJia 360°" },
                    { 14, 3, "Xiaomi Mi Home Security Camera 1080p Magnetic Mount" },
                    { 24, 4, "Xiaomi Mi Sports Bluetooth Earphones YDLYEJ01LM (белый)" },
                    { 13, 3, "Xiaomi MiJia 360° Sphere Panoramic Camera" },
                    { 11, 2, "Xiaomi Mi Notebook Air 13.3 JYU4052CN" },
                    { 10, 2, "Xiaomi RedmiBook 13 Ryzen Edition 2020 JYU4251CN" },
                    { 9, 2, "Xiaomi Mi Notebook Pro 2020 JYU4222CN" },
                    { 8, 2, "Xiaomi Mi Gaming Laptop Enhanced Edition 2019 JYU4144CN" },
                    { 7, 2, "Xiaomi RedmiBook 16 JYU4277CN" },
                    { 6, 1, "Xiaomi Redmi 9C" },
                    { 5, 1, "Xiaomi Mi Note 10 Lite" },
                    { 4, 1, "Xiaomi Redmi 8" },
                    { 3, 1, "Xiaomi Redmi 7" },
                    { 2, 1, "Xiaomi Redmi Note 9 Pro" },
                    { 12, 2, "Xiaomi Redmi G JYU4313CN" },
                    { 25, 4, "Xiaomi Mi Bluetooth TDLYEJ01JY" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
