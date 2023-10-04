using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace svelte_rpg_backend.Migrations
{
    public partial class RemovedTier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tier",
                table: "MonsterCatalog");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tier",
                table: "MonsterCatalog",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
