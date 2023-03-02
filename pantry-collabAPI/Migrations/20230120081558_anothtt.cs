using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class anothtt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_ItemId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_PantryItems_Ingredients_IngredientId",
                table: "PantryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Ingredients_ingredientsId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_ingredientsId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ingredientsId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "PantryItems",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_PantryItems_IngredientId",
                table: "PantryItems",
                newName: "IX_PantryItems_ItemId");

            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PantryItemId",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_IngredientId",
                table: "Recipes",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_PantryItemId",
                table: "Ingredients",
                column: "PantryItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_PantryItems_PantryItemId",
                table: "Ingredients",
                column: "PantryItemId",
                principalTable: "PantryItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItems_Items_ItemId",
                table: "PantryItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Ingredients_IngredientId",
                table: "Recipes",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_PantryItems_PantryItemId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_PantryItems_Items_ItemId",
                table: "PantryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Ingredients_IngredientId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_IngredientId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_PantryItemId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "PantryItemId",
                table: "Ingredients");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "PantryItems",
                newName: "IngredientId");

            migrationBuilder.RenameIndex(
                name: "IX_PantryItems_ItemId",
                table: "PantryItems",
                newName: "IX_PantryItems_IngredientId");

            migrationBuilder.AddColumn<int>(
                name: "ingredientsId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ingredientsId",
                table: "Recipes",
                column: "ingredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemId",
                table: "Items",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_ItemId",
                table: "Items",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItems_Ingredients_IngredientId",
                table: "PantryItems",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Ingredients_ingredientsId",
                table: "Recipes",
                column: "ingredientsId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
