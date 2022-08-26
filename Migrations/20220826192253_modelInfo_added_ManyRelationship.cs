using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsApi.Migrations
{
    public partial class modelInfo_added_ManyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ModelInfoId",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ModelInfoId",
                table: "Products",
                column: "ModelInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ModelInfoId",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ModelInfoId",
                table: "Products",
                column: "ModelInfoId",
                unique: true);
        }
    }
}
