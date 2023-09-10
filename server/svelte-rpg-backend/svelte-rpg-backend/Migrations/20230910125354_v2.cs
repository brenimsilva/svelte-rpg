using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace svelte_rpg_backend.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStatSet_HeroSet_HeroId",
                table: "CharacterStatSet");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterSet_LootSet_LootId",
                table: "MonsterSet");

            migrationBuilder.DropIndex(
                name: "IX_MonsterSet_LootId",
                table: "MonsterSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterStatSet",
                table: "CharacterStatSet");

            migrationBuilder.DropColumn(
                name: "ActionId",
                table: "SkillTypeSet");

            migrationBuilder.DropColumn(
                name: "LootId",
                table: "MonsterSet");

            migrationBuilder.DropColumn(
                name: "DropChance",
                table: "ItemLootSet");

            migrationBuilder.RenameTable(
                name: "CharacterStatSet",
                newName: "HeroStatSet");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterStatSet_HeroId",
                table: "HeroStatSet",
                newName: "IX_HeroStatSet_HeroId");

            migrationBuilder.AlterColumn<string>(
                name: "StatName",
                table: "StatSet",
                type: "varchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ShortName",
                table: "StatSet",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "StatSet",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ActionId",
                table: "SkillSet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SkillSet",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "DropChance",
                table: "MonsterLootSet",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "MonsterId",
                table: "LootSet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BackPackId",
                table: "HeroSet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeroStatSet",
                table: "HeroStatSet",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BackPack",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackPack", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemSlot",
                columns: table => new
                {
                    ItemSlotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    BackPackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSlot", x => x.ItemSlotId);
                    table.ForeignKey(
                        name: "FK_ItemSlot_BackPack_BackPackId",
                        column: x => x.BackPackId,
                        principalTable: "BackPack",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSet_ActionId",
                table: "SkillSet",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_LootSet_MonsterId",
                table: "LootSet",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSet_ActionTextId",
                table: "ItemSet",
                column: "ActionTextId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSet_ItemTypeId",
                table: "ItemSet",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSet_RarityId",
                table: "ItemSet",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroSet_BackPackId",
                table: "HeroSet",
                column: "BackPackId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroEquipmentSet_HeroId",
                table: "HeroEquipmentSet",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSlot_BackPackId",
                table: "ItemSlot",
                column: "BackPackId");

            migrationBuilder.AddForeignKey(
                name: "FK_HeroEquipmentSet_HeroSet_HeroId",
                table: "HeroEquipmentSet",
                column: "HeroId",
                principalTable: "HeroSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HeroSet_BackPack_BackPackId",
                table: "HeroSet",
                column: "BackPackId",
                principalTable: "BackPack",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HeroStatSet_HeroSet_HeroId",
                table: "HeroStatSet",
                column: "HeroId",
                principalTable: "HeroSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSet_ActionTextSet_ActionTextId",
                table: "ItemSet",
                column: "ActionTextId",
                principalTable: "ActionTextSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSet_ItemTypeSet_ItemTypeId",
                table: "ItemSet",
                column: "ItemTypeId",
                principalTable: "ItemTypeSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSet_RaritySet_RarityId",
                table: "ItemSet",
                column: "RarityId",
                principalTable: "RaritySet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LootSet_MonsterSet_MonsterId",
                table: "LootSet",
                column: "MonsterId",
                principalTable: "MonsterSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillSet_ActionTextSet_ActionId",
                table: "SkillSet",
                column: "ActionId",
                principalTable: "ActionTextSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroEquipmentSet_HeroSet_HeroId",
                table: "HeroEquipmentSet");

            migrationBuilder.DropForeignKey(
                name: "FK_HeroSet_BackPack_BackPackId",
                table: "HeroSet");

            migrationBuilder.DropForeignKey(
                name: "FK_HeroStatSet_HeroSet_HeroId",
                table: "HeroStatSet");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemSet_ActionTextSet_ActionTextId",
                table: "ItemSet");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemSet_ItemTypeSet_ItemTypeId",
                table: "ItemSet");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemSet_RaritySet_RarityId",
                table: "ItemSet");

            migrationBuilder.DropForeignKey(
                name: "FK_LootSet_MonsterSet_MonsterId",
                table: "LootSet");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillSet_ActionTextSet_ActionId",
                table: "SkillSet");

            migrationBuilder.DropTable(
                name: "ItemSlot");

            migrationBuilder.DropTable(
                name: "BackPack");

            migrationBuilder.DropIndex(
                name: "IX_SkillSet_ActionId",
                table: "SkillSet");

            migrationBuilder.DropIndex(
                name: "IX_LootSet_MonsterId",
                table: "LootSet");

            migrationBuilder.DropIndex(
                name: "IX_ItemSet_ActionTextId",
                table: "ItemSet");

            migrationBuilder.DropIndex(
                name: "IX_ItemSet_ItemTypeId",
                table: "ItemSet");

            migrationBuilder.DropIndex(
                name: "IX_ItemSet_RarityId",
                table: "ItemSet");

            migrationBuilder.DropIndex(
                name: "IX_HeroSet_BackPackId",
                table: "HeroSet");

            migrationBuilder.DropIndex(
                name: "IX_HeroEquipmentSet_HeroId",
                table: "HeroEquipmentSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeroStatSet",
                table: "HeroStatSet");

            migrationBuilder.DropColumn(
                name: "ActionId",
                table: "SkillSet");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SkillSet");

            migrationBuilder.DropColumn(
                name: "DropChance",
                table: "MonsterLootSet");

            migrationBuilder.DropColumn(
                name: "MonsterId",
                table: "LootSet");

            migrationBuilder.DropColumn(
                name: "BackPackId",
                table: "HeroSet");

            migrationBuilder.RenameTable(
                name: "HeroStatSet",
                newName: "CharacterStatSet");

            migrationBuilder.RenameIndex(
                name: "IX_HeroStatSet_HeroId",
                table: "CharacterStatSet",
                newName: "IX_CharacterStatSet_HeroId");

            migrationBuilder.AlterColumn<string>(
                name: "StatName",
                table: "StatSet",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(32)",
                oldMaxLength: 32)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ShortName",
                table: "StatSet",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "StatSet",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ActionId",
                table: "SkillTypeSet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LootId",
                table: "MonsterSet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "DropChance",
                table: "ItemLootSet",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterStatSet",
                table: "CharacterStatSet",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterSet_LootId",
                table: "MonsterSet",
                column: "LootId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStatSet_HeroSet_HeroId",
                table: "CharacterStatSet",
                column: "HeroId",
                principalTable: "HeroSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterSet_LootSet_LootId",
                table: "MonsterSet",
                column: "LootId",
                principalTable: "LootSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
