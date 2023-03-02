using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class anothertrueeor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_PantryItems_PantryItemId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "PantryItemId",
                table: "Items",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_PantryItemId",
                table: "Items",
                newName: "IX_Items_ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_ItemId",
                table: "Items",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_ItemId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Items",
                newName: "PantryItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ItemId",
                table: "Items",
                newName: "IX_Items_PantryItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_PantryItems_PantryItemId",
                table: "Items",
                column: "PantryItemId",
                principalTable: "PantryItems",
                principalColumn: "Id");
        }
    }
}
