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
                name: "ActionTextSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ActionName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionTextSet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AttributeSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShortName = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AttributeName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeSet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ConfigSet",
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
                    table.PrimaryKey("PK_ConfigSet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EquipmentSlotSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(24)", maxLength: 24, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSlotSet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemListId = table.Column<int>(type: "int", nullable: false),
                    ItemLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemTypeSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypeSet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MonsterSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterSet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RaritySet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaritySet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SkillTypeSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillTypeSet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StatSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShortName = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StatName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatSet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserTypeSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(24)", maxLength: 24, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypeSet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemAttributeSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAttributeSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemAttributeSet_AttributeSet_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "AttributeSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemAttributeSet_ItemSet_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ItemSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LootSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Exp = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    MonsterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LootSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LootSet_MonsterSet_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "MonsterSet",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MonsterAttributeSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterAttributeSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonsterAttributeSet_AttributeSet_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "AttributeSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterAttributeSet_MonsterSet_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "MonsterSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemStatSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStatSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemStatSet_ItemSet_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ItemSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemStatSet_StatSet_StatId",
                        column: x => x.StatId,
                        principalTable: "StatSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MonsterStatSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatId = table.Column<int>(type: "int", nullable: false),
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterStatSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonsterStatSet_MonsterSet_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "MonsterSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterStatSet_StatSet_StatId",
                        column: x => x.StatId,
                        principalTable: "StatSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserSet",
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
                    table.PrimaryKey("PK_UserSet", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserSet_UserTypeSet_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypeSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemLootSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LootId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemLootSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemLootSet_ItemSet_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ItemSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemLootSet_LootSet_LootId",
                        column: x => x.LootId,
                        principalTable: "LootSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MonsterLootSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    LootId = table.Column<int>(type: "int", nullable: false),
                    DropChance = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterLootSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonsterLootSet_LootSet_LootId",
                        column: x => x.LootId,
                        principalTable: "LootSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterLootSet_MonsterSet_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "MonsterSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HeroSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HeroName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Exp = table.Column<int>(type: "int", nullable: false),
                    StatPoints = table.Column<int>(type: "int", nullable: false),
                    PerkPoints = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroSet_UserSet_UserId",
                        column: x => x.UserId,
                        principalTable: "UserSet",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HeroAttributeSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroAttributeSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroAttributeSet_AttributeSet_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "AttributeSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroAttributeSet_HeroSet_HeroId",
                        column: x => x.HeroId,
                        principalTable: "HeroSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HeroEquipmentSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EquipmentSlotId = table.Column<int>(type: "int", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroEquipmentSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroEquipmentSet_EquipmentSlotSet_EquipmentSlotId",
                        column: x => x.EquipmentSlotId,
                        principalTable: "EquipmentSlotSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroEquipmentSet_HeroSet_HeroId",
                        column: x => x.HeroId,
                        principalTable: "HeroSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroEquipmentSet_ItemSet_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ItemSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HeroStatSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatId = table.Column<int>(type: "int", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroStatSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroStatSet_HeroSet_HeroId",
                        column: x => x.HeroId,
                        principalTable: "HeroSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroStatSet_StatSet_StatId",
                        column: x => x.StatId,
                        principalTable: "StatSet",
                        principalColumn: "Id",
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
                        name: "FK_ItemSlotSet_HeroSet_HeroId",
                        column: x => x.HeroId,
                        principalTable: "HeroSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSlotSet_ItemSet_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ItemSet",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerkSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PerkName = table.Column<string>(type: "varchar(24)", maxLength: 24, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HeroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerkSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerkSet_HeroSet_HeroId",
                        column: x => x.HeroId,
                        principalTable: "HeroSet",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SkillSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SkillTypeId = table.Column<int>(type: "int", nullable: false),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SkillBasePower = table.Column<int>(type: "int", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillSet_ActionTextSet_ActionId",
                        column: x => x.ActionId,
                        principalTable: "ActionTextSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillSet_HeroSet_HeroId",
                        column: x => x.HeroId,
                        principalTable: "HeroSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SkillSet_SkillTypeSet_SkillTypeId",
                        column: x => x.SkillTypeId,
                        principalTable: "SkillTypeSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerkAttributeSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    PerkId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerkAttributeSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerkAttributeSet_AttributeSet_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "AttributeSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerkAttributeSet_PerkSet_PerkId",
                        column: x => x.PerkId,
                        principalTable: "PerkSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerkStatSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatId = table.Column<int>(type: "int", nullable: false),
                    PerkId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerkStatSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerkStatSet_PerkSet_PerkId",
                        column: x => x.PerkId,
                        principalTable: "PerkSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerkStatSet_StatSet_StatId",
                        column: x => x.StatId,
                        principalTable: "StatSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_HeroAttributeSet_AttributeId",
                table: "HeroAttributeSet",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroAttributeSet_HeroId",
                table: "HeroAttributeSet",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroEquipmentSet_EquipmentSlotId",
                table: "HeroEquipmentSet",
                column: "EquipmentSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroEquipmentSet_HeroId",
                table: "HeroEquipmentSet",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroEquipmentSet_ItemId",
                table: "HeroEquipmentSet",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroSet_UserId",
                table: "HeroSet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroStatSet_HeroId",
                table: "HeroStatSet",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroStatSet_StatId",
                table: "HeroStatSet",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAttributeSet_AttributeId",
                table: "ItemAttributeSet",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAttributeSet_ItemId",
                table: "ItemAttributeSet",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemLootSet_ItemId",
                table: "ItemLootSet",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemLootSet_LootId",
                table: "ItemLootSet",
                column: "LootId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSlotSet_HeroId",
                table: "ItemSlotSet",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSlotSet_ItemId",
                table: "ItemSlotSet",
                column: "ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemStatSet_ItemId",
                table: "ItemStatSet",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStatSet_StatId",
                table: "ItemStatSet",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_LootSet_MonsterId",
                table: "LootSet",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterAttributeSet_AttributeId",
                table: "MonsterAttributeSet",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterAttributeSet_MonsterId",
                table: "MonsterAttributeSet",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLootSet_LootId",
                table: "MonsterLootSet",
                column: "LootId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLootSet_MonsterId",
                table: "MonsterLootSet",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterStatSet_MonsterId",
                table: "MonsterStatSet",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterStatSet_StatId",
                table: "MonsterStatSet",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_PerkAttributeSet_AttributeId",
                table: "PerkAttributeSet",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_PerkAttributeSet_PerkId",
                table: "PerkAttributeSet",
                column: "PerkId");

            migrationBuilder.CreateIndex(
                name: "IX_PerkSet_HeroId",
                table: "PerkSet",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_PerkStatSet_PerkId",
                table: "PerkStatSet",
                column: "PerkId");

            migrationBuilder.CreateIndex(
                name: "IX_PerkStatSet_StatId",
                table: "PerkStatSet",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSet_ActionId",
                table: "SkillSet",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSet_HeroId",
                table: "SkillSet",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSet_SkillTypeId",
                table: "SkillSet",
                column: "SkillTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSet_UserTypeId",
                table: "UserSet",
                column: "UserTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigSet");

            migrationBuilder.DropTable(
                name: "HeroAttributeSet");

            migrationBuilder.DropTable(
                name: "HeroEquipmentSet");

            migrationBuilder.DropTable(
                name: "HeroStatSet");

            migrationBuilder.DropTable(
                name: "ItemAttributeSet");

            migrationBuilder.DropTable(
                name: "ItemLootSet");

            migrationBuilder.DropTable(
                name: "ItemSlotSet");

            migrationBuilder.DropTable(
                name: "ItemStatSet");

            migrationBuilder.DropTable(
                name: "ItemTypeSet");

            migrationBuilder.DropTable(
                name: "MonsterAttributeSet");

            migrationBuilder.DropTable(
                name: "MonsterLootSet");

            migrationBuilder.DropTable(
                name: "MonsterStatSet");

            migrationBuilder.DropTable(
                name: "PerkAttributeSet");

            migrationBuilder.DropTable(
                name: "PerkStatSet");

            migrationBuilder.DropTable(
                name: "RaritySet");

            migrationBuilder.DropTable(
                name: "SkillSet");

            migrationBuilder.DropTable(
                name: "EquipmentSlotSet");

            migrationBuilder.DropTable(
                name: "ItemSet");

            migrationBuilder.DropTable(
                name: "LootSet");

            migrationBuilder.DropTable(
                name: "AttributeSet");

            migrationBuilder.DropTable(
                name: "PerkSet");

            migrationBuilder.DropTable(
                name: "StatSet");

            migrationBuilder.DropTable(
                name: "ActionTextSet");

            migrationBuilder.DropTable(
                name: "SkillTypeSet");

            migrationBuilder.DropTable(
                name: "MonsterSet");

            migrationBuilder.DropTable(
                name: "HeroSet");

            migrationBuilder.DropTable(
                name: "UserSet");

            migrationBuilder.DropTable(
                name: "UserTypeSet");
        }
    }
}
