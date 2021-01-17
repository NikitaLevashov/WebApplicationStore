using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationStoreDAL.Migrations
{
    public partial class AddProrertyCatalogID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Catalogs_CatalogId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CatalogId",
                table: "Products",
                newName: "CatalogID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CatalogId",
                table: "Products",
                newName: "IX_Products_CatalogID");

            migrationBuilder.AlterColumn<int>(
                name: "CatalogID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Catalogs_CatalogID",
                table: "Products",
                column: "CatalogID",
                principalTable: "Catalogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Catalogs_CatalogID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CatalogID",
                table: "Products",
                newName: "CatalogId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CatalogID",
                table: "Products",
                newName: "IX_Products_CatalogId");

            migrationBuilder.AlterColumn<int>(
                name: "CatalogId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Catalogs_CatalogId",
                table: "Products",
                column: "CatalogId",
                principalTable: "Catalogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
