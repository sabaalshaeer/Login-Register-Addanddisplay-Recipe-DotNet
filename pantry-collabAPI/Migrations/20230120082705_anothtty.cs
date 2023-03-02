using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class anothtty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "PantryItems",
                newName: "IngredientId");

            migrationBuilder.RenameIndex(
                name: "IX_PantryItems_ItemId",
                table: "PantryItems",
                newName: "IX_PantryItems_IngredientId");

            migrationBuilder.RenameColumn(
                name: "PantryItemId",
                table: "Ingredients",
                newName: "RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_PantryItemId",
                table: "Ingredients",
                newName: "IX_Ingredients_RecipeId");

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
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_PantryItems_PantryItemId",
                table: "Items",
                column: "PantryItemId",
                principalTable: "PantryItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItems_Ingredients_IngredientId",
                table: "PantryItems",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_PantryItems_PantryItemId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_PantryItems_Ingredients_IngredientId",
                table: "PantryItems");

            migrationBuilder.DropIndex(
                name: "IX_Items_PantryItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "PantryItemId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "PantryItems",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_PantryItems_IngredientId",
                table: "PantryItems",
                newName: "IX_PantryItems_ItemId");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "Ingredients",
                newName: "PantryItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                newName: "IX_Ingredients_PantryItemId");

            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_IngredientId",
                table: "Recipes",
                column: "IngredientId");

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
    }
}
