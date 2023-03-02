using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class anothttyyu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_PantryItems_PantryItemId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_PantryItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "PantryItemId",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "itemsId",
                table: "PantryItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PantryItems_itemsId",
                table: "PantryItems",
                column: "itemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItems_Items_itemsId",
                table: "PantryItems",
                column: "itemsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PantryItems_Items_itemsId",
                table: "PantryItems");

            migrationBuilder.DropIndex(
                name: "IX_PantryItems_itemsId",
                table: "PantryItems");

            migrationBuilder.DropColumn(
                name: "itemsId",
                table: "PantryItems");

            migrationBuilder.AddColumn<int>(
                name: "PantryItemId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_PantryItemId",
                table: "Items",
                column: "PantryItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_PantryItems_PantryItemId",
                table: "Items",
                column: "PantryItemId",
                principalTable: "PantryItems",
                principalColumn: "Id");
        }
    }
}
