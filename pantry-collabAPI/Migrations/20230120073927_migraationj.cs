using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class migraationj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_PantryItems_PantryItemId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Ingredients",
                newName: "Url");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Recipes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ingredientsId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "PantryItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "PantryItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "PantryItemId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ingredientsId",
                table: "Recipes",
                column: "ingredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_PantryItems_IngredientId",
                table: "PantryItems",
                column: "IngredientId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Ingredients_ingredientsId",
                table: "Recipes",
                column: "ingredientsId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_PantryItems_PantryItemId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_PantryItems_Ingredients_IngredientId",
                table: "PantryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Ingredients_ingredientsId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_ingredientsId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_PantryItems_IngredientId",
                table: "PantryItems");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ingredientsId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "PantryItems");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "PantryItems");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Ingredients",
                newName: "Image");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PantryItemId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_PantryItems_PantryItemId",
                table: "Items",
                column: "PantryItemId",
                principalTable: "PantryItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
