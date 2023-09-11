using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace svelte_rpg_backend.Migrations
{
    public partial class CorrectRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemSet_ItemListSet_ItemListId",
                table: "ItemSet");

            migrationBuilder.DropForeignKey(
                name: "FK_LootSet_MonsterSet_MonsterId",
                table: "LootSet");

            migrationBuilder.DropTable(
                name: "ItemListSet");

            migrationBuilder.DropIndex(
                name: "IX_LootSet_MonsterId",
                table: "LootSet");

            migrationBuilder.DropColumn(
                name: "MonsterId",
                table: "LootSet");

            migrationBuilder.RenameColumn(
                name: "ItemListId",
                table: "ItemSet",
                newName: "ItemCatalogId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemSet_ItemListId",
                table: "ItemSet",
                newName: "IX_ItemSet_ItemCatalogId");

            migrationBuilder.CreateTable(
                name: "ItemCatalogSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItemTypeId = table.Column<int>(type: "int", nullable: false),
                    RarityId = table.Column<int>(type: "int", nullable: false),
                    ActionTextId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCatalogSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCatalogSet_ActionTextSet_ActionTextId",
                        column: x => x.ActionTextId,
                        principalTable: "ActionTextSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCatalogSet_ItemTypeSet_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypeSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCatalogSet_RaritySet_RarityId",
                        column: x => x.RarityId,
                        principalTable: "RaritySet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCatalogSet_ActionTextId",
                table: "ItemCatalogSet",
                column: "ActionTextId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCatalogSet_ItemTypeId",
                table: "ItemCatalogSet",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCatalogSet_RarityId",
                table: "ItemCatalogSet",
                column: "RarityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSet_ItemCatalogSet_ItemCatalogId",
                table: "ItemSet",
                column: "ItemCatalogId",
                principalTable: "ItemCatalogSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemSet_ItemCatalogSet_ItemCatalogId",
                table: "ItemSet");

            migrationBuilder.DropTable(
                name: "ItemCatalogSet");

            migrationBuilder.RenameColumn(
                name: "ItemCatalogId",
                table: "ItemSet",
                newName: "ItemListId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemSet_ItemCatalogId",
                table: "ItemSet",
                newName: "IX_ItemSet_ItemListId");

            migrationBuilder.AddColumn<int>(
                name: "MonsterId",
                table: "LootSet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemListSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ActionTextId = table.Column<int>(type: "int", nullable: false),
                    ItemTypeId = table.Column<int>(type: "int", nullable: false),
                    RarityId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemListSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemListSet_ActionTextSet_ActionTextId",
                        column: x => x.ActionTextId,
                        principalTable: "ActionTextSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemListSet_ItemTypeSet_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypeSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemListSet_RaritySet_RarityId",
                        column: x => x.RarityId,
                        principalTable: "RaritySet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_LootSet_MonsterId",
                table: "LootSet",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemListSet_ActionTextId",
                table: "ItemListSet",
                column: "ActionTextId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemListSet_ItemTypeId",
                table: "ItemListSet",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemListSet_RarityId",
                table: "ItemListSet",
                column: "RarityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSet_ItemListSet_ItemListId",
                table: "ItemSet",
                column: "ItemListId",
                principalTable: "ItemListSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LootSet_MonsterSet_MonsterId",
                table: "LootSet",
                column: "MonsterId",
                principalTable: "MonsterSet",
                principalColumn: "Id");
        }
    }
}
