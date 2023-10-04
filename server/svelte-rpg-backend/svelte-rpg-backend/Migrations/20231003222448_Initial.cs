using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace svelte_rpg_backend.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ActionText",
                columns: table => new
                {
                    ActionTextId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ActionName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionText", x => x.ActionTextId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Tier = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.ActorId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Attribute",
                columns: table => new
                {
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    ShortName = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AttributeName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attribute", x => x.AttributeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Config",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EquipmentSlot",
                columns: table => new
                {
                    EquipmentSlotId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(24)", maxLength: 24, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSlot", x => x.EquipmentSlotId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemType",
                columns: table => new
                {
                    ItemTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemType", x => x.ItemTypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Loot",
                columns: table => new
                {
                    LootId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Exp = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loot", x => x.LootId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MonsterCatalog",
                columns: table => new
                {
                    MonsterCatalogId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Tier = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterCatalog", x => x.MonsterCatalogId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rarity",
                columns: table => new
                {
                    RarityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rarity", x => x.RarityId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SkillType",
                columns: table => new
                {
                    SkillTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillType", x => x.SkillTypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Stat",
                columns: table => new
                {
                    StatId = table.Column<int>(type: "int", nullable: false),
                    ShortName = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StatName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stat", x => x.StatId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(24)", maxLength: 24, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ActorAttribute",
                columns: table => new
                {
                    ActorAttributeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "double", nullable: false),
                    MonsterCatalogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorAttribute", x => x.ActorAttributeId);
                    table.ForeignKey(
                        name: "FK_ActorAttribute_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorAttribute_Attribute_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attribute",
                        principalColumn: "AttributeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorAttribute_MonsterCatalog_MonsterCatalogId",
                        column: x => x.MonsterCatalogId,
                        principalTable: "MonsterCatalog",
                        principalColumn: "MonsterCatalogId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Monster",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    MonsterCatalogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monster", x => x.ActorId);
                    table.ForeignKey(
                        name: "FK_Monster_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Monster_MonsterCatalog_MonsterCatalogId",
                        column: x => x.MonsterCatalogId,
                        principalTable: "MonsterCatalog",
                        principalColumn: "MonsterCatalogId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemCatalog",
                columns: table => new
                {
                    ItemCatalogId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ItemCatalog", x => x.ItemCatalogId);
                    table.ForeignKey(
                        name: "FK_ItemCatalog_ActionText_ActionTextId",
                        column: x => x.ActionTextId,
                        principalTable: "ActionText",
                        principalColumn: "ActionTextId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCatalog_ItemType_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemType",
                        principalColumn: "ItemTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCatalog_Rarity_RarityId",
                        column: x => x.RarityId,
                        principalTable: "Rarity",
                        principalColumn: "RarityId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ActorStat",
                columns: table => new
                {
                    ActorStatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    MonsterCatalogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorStat", x => x.ActorStatId);
                    table.ForeignKey(
                        name: "FK_ActorStat_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorStat_MonsterCatalog_MonsterCatalogId",
                        column: x => x.MonsterCatalogId,
                        principalTable: "MonsterCatalog",
                        principalColumn: "MonsterCatalogId");
                    table.ForeignKey(
                        name: "FK_ActorStat_Stat_StatId",
                        column: x => x.StatId,
                        principalTable: "Stat",
                        principalColumn: "StatId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AttributeStatRatio",
                columns: table => new
                {
                    AttributeStatsRatioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatId = table.Column<int>(type: "int", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    Ratio = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeStatRatio", x => x.AttributeStatsRatioId);
                    table.ForeignKey(
                        name: "FK_AttributeStatRatio_Attribute_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attribute",
                        principalColumn: "AttributeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttributeStatRatio_Stat_StatId",
                        column: x => x.StatId,
                        principalTable: "Stat",
                        principalColumn: "StatId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_UserType_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MonsterLoot",
                columns: table => new
                {
                    MonsterLootId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonsterCatalogId = table.Column<int>(type: "int", nullable: false),
                    LootId = table.Column<int>(type: "int", nullable: false),
                    DropChance = table.Column<double>(type: "double", nullable: false),
                    MonsterActorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterLoot", x => x.MonsterLootId);
                    table.ForeignKey(
                        name: "FK_MonsterLoot_Loot_LootId",
                        column: x => x.LootId,
                        principalTable: "Loot",
                        principalColumn: "LootId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterLoot_Monster_MonsterActorId",
                        column: x => x.MonsterActorId,
                        principalTable: "Monster",
                        principalColumn: "ActorId");
                    table.ForeignKey(
                        name: "FK_MonsterLoot_MonsterCatalog_MonsterCatalogId",
                        column: x => x.MonsterCatalogId,
                        principalTable: "MonsterCatalog",
                        principalColumn: "MonsterCatalogId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemCatalogId = table.Column<int>(type: "int", nullable: false),
                    ItemLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Item_ItemCatalog_ItemCatalogId",
                        column: x => x.ItemCatalogId,
                        principalTable: "ItemCatalog",
                        principalColumn: "ItemCatalogId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hero",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Exp = table.Column<int>(type: "int", nullable: false),
                    StatPoints = table.Column<int>(type: "int", nullable: false),
                    PerkPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hero", x => x.ActorId);
                    table.ForeignKey(
                        name: "FK_Hero_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hero_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemAttributeSet",
                columns: table => new
                {
                    ItemAttributeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "double", nullable: false),
                    ItemId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAttributeSet", x => x.ItemAttributeId);
                    table.ForeignKey(
                        name: "FK_ItemAttributeSet_Attribute_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attribute",
                        principalColumn: "AttributeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemAttributeSet_Item_ItemId1",
                        column: x => x.ItemId1,
                        principalTable: "Item",
                        principalColumn: "ItemId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemLoot",
                columns: table => new
                {
                    ItemLootId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LootId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemLoot", x => x.ItemLootId);
                    table.ForeignKey(
                        name: "FK_ItemLoot_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemLoot_Loot_LootId",
                        column: x => x.LootId,
                        principalTable: "Loot",
                        principalColumn: "LootId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemStat",
                columns: table => new
                {
                    ItemStatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStat", x => x.ItemStatId);
                    table.ForeignKey(
                        name: "FK_ItemStat_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemStat_Stat_StatId",
                        column: x => x.StatId,
                        principalTable: "Stat",
                        principalColumn: "StatId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BattleState",
                columns: table => new
                {
                    BattleStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleState", x => x.BattleStateId);
                    table.ForeignKey(
                        name: "FK_BattleState_Hero_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Hero",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BattleState_Monster_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monster",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HeroEquipment",
                columns: table => new
                {
                    HeroEquipmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EquipmentSlotId = table.Column<int>(type: "int", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroEquipment", x => x.HeroEquipmentId);
                    table.ForeignKey(
                        name: "FK_HeroEquipment_EquipmentSlot_EquipmentSlotId",
                        column: x => x.EquipmentSlotId,
                        principalTable: "EquipmentSlot",
                        principalColumn: "EquipmentSlotId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroEquipment_Hero_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Hero",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroEquipment_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemSlotSet",
                columns: table => new
                {
                    ItemSlotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    HeroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSlotSet", x => x.ItemSlotId);
                    table.ForeignKey(
                        name: "FK_ItemSlotSet_Hero_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Hero",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSlotSet_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Perk",
                columns: table => new
                {
                    PerkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PerkName = table.Column<string>(type: "varchar(24)", maxLength: 24, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HeroActorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perk", x => x.PerkId);
                    table.ForeignKey(
                        name: "FK_Perk_Hero_HeroActorId",
                        column: x => x.HeroActorId,
                        principalTable: "Hero",
                        principalColumn: "ActorId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SkillTypeId = table.Column<int>(type: "int", nullable: false),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SkillBasePower = table.Column<int>(type: "int", nullable: false),
                    HeroActorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Skill_ActionText_ActionId",
                        column: x => x.ActionId,
                        principalTable: "ActionText",
                        principalColumn: "ActionTextId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Skill_Hero_HeroActorId",
                        column: x => x.HeroActorId,
                        principalTable: "Hero",
                        principalColumn: "ActorId");
                    table.ForeignKey(
                        name: "FK_Skill_SkillType_SkillTypeId",
                        column: x => x.SkillTypeId,
                        principalTable: "SkillType",
                        principalColumn: "SkillTypeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerkAttribute",
                columns: table => new
                {
                    PerkAttributeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    PerkId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerkAttribute", x => x.PerkAttributeId);
                    table.ForeignKey(
                        name: "FK_PerkAttribute_Attribute_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attribute",
                        principalColumn: "AttributeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerkAttribute_Perk_PerkId",
                        column: x => x.PerkId,
                        principalTable: "Perk",
                        principalColumn: "PerkId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerkStat",
                columns: table => new
                {
                    PerkStatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatId = table.Column<int>(type: "int", nullable: false),
                    PerkId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerkStat", x => x.PerkStatId);
                    table.ForeignKey(
                        name: "FK_PerkStat_Perk_PerkId",
                        column: x => x.PerkId,
                        principalTable: "Perk",
                        principalColumn: "PerkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerkStat_Stat_StatId",
                        column: x => x.StatId,
                        principalTable: "Stat",
                        principalColumn: "StatId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ActorAttribute_ActorId",
                table: "ActorAttribute",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorAttribute_AttributeId",
                table: "ActorAttribute",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorAttribute_MonsterCatalogId",
                table: "ActorAttribute",
                column: "MonsterCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorStat_ActorId",
                table: "ActorStat",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorStat_MonsterCatalogId",
                table: "ActorStat",
                column: "MonsterCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorStat_StatId",
                table: "ActorStat",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeStatRatio_AttributeId",
                table: "AttributeStatRatio",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeStatRatio_StatId",
                table: "AttributeStatRatio",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleState_HeroId",
                table: "BattleState",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleState_MonsterId",
                table: "BattleState",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_Hero_UserId",
                table: "Hero",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroEquipment_EquipmentSlotId",
                table: "HeroEquipment",
                column: "EquipmentSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroEquipment_HeroId",
                table: "HeroEquipment",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroEquipment_ItemId",
                table: "HeroEquipment",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemCatalogId",
                table: "Item",
                column: "ItemCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAttributeSet_AttributeId",
                table: "ItemAttributeSet",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAttributeSet_ItemId1",
                table: "ItemAttributeSet",
                column: "ItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCatalog_ActionTextId",
                table: "ItemCatalog",
                column: "ActionTextId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCatalog_ItemTypeId",
                table: "ItemCatalog",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCatalog_RarityId",
                table: "ItemCatalog",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemLoot_ItemId",
                table: "ItemLoot",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemLoot_LootId",
                table: "ItemLoot",
                column: "LootId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSlotSet_HeroId",
                table: "ItemSlotSet",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSlotSet_ItemId",
                table: "ItemSlotSet",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStat_ItemId",
                table: "ItemStat",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStat_StatId",
                table: "ItemStat",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_Monster_MonsterCatalogId",
                table: "Monster",
                column: "MonsterCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLoot_LootId",
                table: "MonsterLoot",
                column: "LootId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLoot_MonsterActorId",
                table: "MonsterLoot",
                column: "MonsterActorId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLoot_MonsterCatalogId",
                table: "MonsterLoot",
                column: "MonsterCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Perk_HeroActorId",
                table: "Perk",
                column: "HeroActorId");

            migrationBuilder.CreateIndex(
                name: "IX_PerkAttribute_AttributeId",
                table: "PerkAttribute",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_PerkAttribute_PerkId",
                table: "PerkAttribute",
                column: "PerkId");

            migrationBuilder.CreateIndex(
                name: "IX_PerkStat_PerkId",
                table: "PerkStat",
                column: "PerkId");

            migrationBuilder.CreateIndex(
                name: "IX_PerkStat_StatId",
                table: "PerkStat",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_ActionId",
                table: "Skill",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_HeroActorId",
                table: "Skill",
                column: "HeroActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_SkillTypeId",
                table: "Skill",
                column: "SkillTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeId",
                table: "User",
                column: "UserTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorAttribute");

            migrationBuilder.DropTable(
                name: "ActorStat");

            migrationBuilder.DropTable(
                name: "AttributeStatRatio");

            migrationBuilder.DropTable(
                name: "BattleState");

            migrationBuilder.DropTable(
                name: "Config");

            migrationBuilder.DropTable(
                name: "HeroEquipment");

            migrationBuilder.DropTable(
                name: "ItemAttributeSet");

            migrationBuilder.DropTable(
                name: "ItemLoot");

            migrationBuilder.DropTable(
                name: "ItemSlotSet");

            migrationBuilder.DropTable(
                name: "ItemStat");

            migrationBuilder.DropTable(
                name: "MonsterLoot");

            migrationBuilder.DropTable(
                name: "PerkAttribute");

            migrationBuilder.DropTable(
                name: "PerkStat");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "EquipmentSlot");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Loot");

            migrationBuilder.DropTable(
                name: "Monster");

            migrationBuilder.DropTable(
                name: "Attribute");

            migrationBuilder.DropTable(
                name: "Perk");

            migrationBuilder.DropTable(
                name: "Stat");

            migrationBuilder.DropTable(
                name: "SkillType");

            migrationBuilder.DropTable(
                name: "ItemCatalog");

            migrationBuilder.DropTable(
                name: "MonsterCatalog");

            migrationBuilder.DropTable(
                name: "Hero");

            migrationBuilder.DropTable(
                name: "ActionText");

            migrationBuilder.DropTable(
                name: "ItemType");

            migrationBuilder.DropTable(
                name: "Rarity");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserType");
        }
    }
}
