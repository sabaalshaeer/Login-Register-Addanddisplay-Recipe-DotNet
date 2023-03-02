using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class threerelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PantryItems_Ingredients_IngredientId",
                table: "PantryItems");

            migrationBuilder.DropIndex(
                name: "IX_PantryItems_IngredientId",
                table: "PantryItems");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "PantryItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "PantryItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PantryItems_IngredientId",
                table: "PantryItems",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItems_Ingredients_IngredientId",
                table: "PantryItems",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");
        }
    }
}
