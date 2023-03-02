using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class relal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_PantryItems_Ingredients_ingredientId",
                table: "PantryItems");

            migrationBuilder.DropIndex(
                name: "IX_PantryItems_ingredientId",
                table: "PantryItems");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "PantryItems");

            migrationBuilder.DropColumn(
                name: "ingredientId",
                table: "PantryItems");

            migrationBuilder.DropColumn(
                name: "PantryItemId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "Ingredients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "PantryItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ingredientId",
                table: "PantryItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PantryItemId",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecipeId",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PantryItems_ingredientId",
                table: "PantryItems",
                column: "ingredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItems_Ingredients_ingredientId",
                table: "PantryItems",
                column: "ingredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");
        }
    }
}
