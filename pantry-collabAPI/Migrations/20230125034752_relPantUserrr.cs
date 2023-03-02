using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class relPantUserrr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PantryItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PantryItems_UserId",
                table: "PantryItems",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItems_Users_UserId",
                table: "PantryItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PantryItems_Users_UserId",
                table: "PantryItems");

            migrationBuilder.DropIndex(
                name: "IX_PantryItems_UserId",
                table: "PantryItems");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PantryItems");
        }
    }
}
