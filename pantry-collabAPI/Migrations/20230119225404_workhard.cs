using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class workhard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ingredientId",
                table: "PantryItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PantryItemId",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PantryItems_ingredientId",
                table: "PantryItems",
                column: "ingredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItems_Ingredients_ingredientId",
                table: "PantryItems",
                column: "ingredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PantryItems_Ingredients_ingredientId",
                table: "PantryItems");

            migrationBuilder.DropIndex(
                name: "IX_PantryItems_ingredientId",
                table: "PantryItems");

            migrationBuilder.DropColumn(
                name: "ingredientId",
                table: "PantryItems");

            migrationBuilder.DropColumn(
                name: "PantryItemId",
                table: "Ingredients");
        }
    }
}
