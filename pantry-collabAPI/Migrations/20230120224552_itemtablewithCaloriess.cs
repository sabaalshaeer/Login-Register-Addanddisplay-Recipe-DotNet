using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class itemtablewithCaloriess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "PantryItems",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<double>(
                name: "Calories",
                table: "Items",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Items",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Items");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "PantryItems",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
