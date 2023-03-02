using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class goodluck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_PantryItems_PantryItemId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_PantryItems_Items_ItemID",
                table: "PantryItems");

            migrationBuilder.DropIndex(
                name: "IX_PantryItems_ItemID",
                table: "PantryItems");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_PantryItemId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "PantryItems");

            migrationBuilder.DropColumn(
                name: "PantryItemId",
                table: "Ingredients");

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
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
                name: "IX_PantryItems_ItemID",
                table: "PantryItems",
                column: "ItemID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_PantryItemId",
                table: "Ingredients",
                column: "PantryItemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_PantryItems_PantryItemId",
                table: "Ingredients",
                column: "PantryItemId",
                principalTable: "PantryItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItems_Items_ItemID",
                table: "PantryItems",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
