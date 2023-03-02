using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pantry_collabAPI.Migrations
{
    public partial class commentinstedotstep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "step",
                table: "Steps",
                newName: "comment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "comment",
                table: "Steps",
                newName: "step");
        }
    }
}
