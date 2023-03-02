using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class anotd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
