using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class relationbetweenitemandPantry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "PantryItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PantryItemId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Items_PantryItemId",
                table: "Items",
                column: "PantryItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_PantryItems_PantryItemId",
                table: "Items",
                column: "PantryItemId",
                principalTable: "PantryItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_PantryItems_PantryItemId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_PantryItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "PantryItems");

            migrationBuilder.DropColumn(
                name: "PantryItemId",
                table: "Items");
        }
    }
}
