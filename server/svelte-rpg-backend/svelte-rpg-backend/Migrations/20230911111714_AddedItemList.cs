using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace svelte_rpg_backend.Migrations
{
    public partial class AddedItemList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemListSet",
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
                name: "IX_ItemSet_ItemListId",
                table: "ItemSet",
                column: "ItemListId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemSet_ItemListSet_ItemListId",
                table: "ItemSet");

            migrationBuilder.DropTable(
                name: "ItemListSet");

            migrationBuilder.DropIndex(
                name: "IX_ItemSet_ItemListId",
                table: "ItemSet");
        }
    }
}
