﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using svelte_rpg_backend.Context;

#nullable disable

namespace svelte_rpg_backend.Migrations
{
    [DbContext(typeof(RpgContext))]
    [Migration("20231003222448_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("svelte_rpg_backend.Models.ActionText", b =>
                {
                    b.Property<int>("ActionTextId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ActionName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("ActionTextId");

                    b.ToTable("ActionText");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Tier")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ActorId");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ActorAttribute", b =>
                {
                    b.Property<int>("ActorAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.Property<int?>("MonsterCatalogId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.HasKey("ActorAttributeId");

                    b.HasIndex("ActorId");

                    b.HasIndex("AttributeId");

                    b.HasIndex("MonsterCatalogId");

                    b.ToTable("ActorAttribute");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ActorStat", b =>
                {
                    b.Property<int>("ActorStatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int?>("MonsterCatalogId")
                        .HasColumnType("int");

                    b.Property<int>("StatId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ActorStatId");

                    b.HasIndex("ActorId");

                    b.HasIndex("MonsterCatalogId");

                    b.HasIndex("StatId");

                    b.ToTable("ActorStat");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Attribute", b =>
                {
                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.Property<string>("AttributeName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("AttributeId");

                    b.ToTable("Attribute");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.AttributeStatsRatio", b =>
                {
                    b.Property<int>("AttributeStatsRatioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.Property<double>("Ratio")
                        .HasColumnType("double");

                    b.Property<int>("StatId")
                        .HasColumnType("int");

                    b.HasKey("AttributeStatsRatioId");

                    b.HasIndex("AttributeId");

                    b.HasIndex("StatId");

                    b.ToTable("AttributeStatRatio");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.BattleState", b =>
                {
                    b.Property<int>("BattleStateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("HeroId")
                        .HasColumnType("int");

                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.HasKey("BattleStateId");

                    b.HasIndex("HeroId");

                    b.HasIndex("MonsterId");

                    b.ToTable("BattleState");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Config", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Config");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.EquipmentSlot", b =>
                {
                    b.Property<int>("EquipmentSlotId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("varchar(24)");

                    b.HasKey("EquipmentSlotId");

                    b.ToTable("EquipmentSlot");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.HeroEquipment", b =>
                {
                    b.Property<int>("HeroEquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EquipmentSlotId")
                        .HasColumnType("int");

                    b.Property<int>("HeroId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("HeroEquipmentId");

                    b.HasIndex("EquipmentSlotId");

                    b.HasIndex("HeroId");

                    b.HasIndex("ItemId");

                    b.ToTable("HeroEquipment");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ItemCatalogId")
                        .HasColumnType("int");

                    b.Property<int>("ItemLevel")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("ItemCatalogId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ItemAttribute", b =>
                {
                    b.Property<int>("ItemAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("ItemId1")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.HasKey("ItemAttributeId");

                    b.HasIndex("AttributeId");

                    b.HasIndex("ItemId1");

                    b.ToTable("ItemAttributeSet");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ItemCatalog", b =>
                {
                    b.Property<int>("ItemCatalogId")
                        .HasColumnType("int");

                    b.Property<int>("ActionTextId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<int>("RarityId")
                        .HasColumnType("int");

                    b.HasKey("ItemCatalogId");

                    b.HasIndex("ActionTextId");

                    b.HasIndex("ItemTypeId");

                    b.HasIndex("RarityId");

                    b.ToTable("ItemCatalog");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ItemLoot", b =>
                {
                    b.Property<int>("ItemLootId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("LootId")
                        .HasColumnType("int");

                    b.HasKey("ItemLootId");

                    b.HasIndex("ItemId");

                    b.HasIndex("LootId");

                    b.ToTable("ItemLoot");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ItemSlot", b =>
                {
                    b.Property<int>("ItemSlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HeroId")
                        .HasColumnType("int");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("ItemSlotId");

                    b.HasIndex("HeroId");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemSlotSet");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ItemStat", b =>
                {
                    b.Property<int>("ItemStatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("StatId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ItemStatId");

                    b.HasIndex("ItemId");

                    b.HasIndex("StatId");

                    b.ToTable("ItemStat");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ItemType", b =>
                {
                    b.Property<int>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ItemTypeId");

                    b.ToTable("ItemType");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Loot", b =>
                {
                    b.Property<int>("LootId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Exp")
                        .HasColumnType("int");

                    b.Property<int>("Gold")
                        .HasColumnType("int");

                    b.HasKey("LootId");

                    b.ToTable("Loot");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.MonsterCatalog", b =>
                {
                    b.Property<int>("MonsterCatalogId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Tier")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("MonsterCatalogId");

                    b.ToTable("MonsterCatalog", (string)null);
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.MonsterLoot", b =>
                {
                    b.Property<int>("MonsterLootId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("DropChance")
                        .HasColumnType("double");

                    b.Property<int>("LootId")
                        .HasColumnType("int");

                    b.Property<int?>("MonsterActorId")
                        .HasColumnType("int");

                    b.Property<int>("MonsterCatalogId")
                        .HasColumnType("int");

                    b.HasKey("MonsterLootId");

                    b.HasIndex("LootId");

                    b.HasIndex("MonsterActorId");

                    b.HasIndex("MonsterCatalogId");

                    b.ToTable("MonsterLoot");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Perk", b =>
                {
                    b.Property<int>("PerkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("HeroActorId")
                        .HasColumnType("int");

                    b.Property<string>("PerkName")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("varchar(24)");

                    b.HasKey("PerkId");

                    b.HasIndex("HeroActorId");

                    b.ToTable("Perk");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.PerkAttribute", b =>
                {
                    b.Property<int>("PerkAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.Property<int>("PerkId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.HasKey("PerkAttributeId");

                    b.HasIndex("AttributeId");

                    b.HasIndex("PerkId");

                    b.ToTable("PerkAttribute");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.PerkStat", b =>
                {
                    b.Property<int>("PerkStatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PerkId")
                        .HasColumnType("int");

                    b.Property<int>("StatId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("PerkStatId");

                    b.HasIndex("PerkId");

                    b.HasIndex("StatId");

                    b.ToTable("PerkStat");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Rarity", b =>
                {
                    b.Property<int>("RarityId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("RarityId");

                    b.ToTable("Rarity");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ActionId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("HeroActorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SkillBasePower")
                        .HasColumnType("int");

                    b.Property<int>("SkillTypeId")
                        .HasColumnType("int");

                    b.HasKey("SkillId");

                    b.HasIndex("ActionId");

                    b.HasIndex("HeroActorId");

                    b.HasIndex("SkillTypeId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.SkillType", b =>
                {
                    b.Property<int>("SkillTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("SkillTypeId");

                    b.ToTable("SkillType");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Stat", b =>
                {
                    b.Property<int>("StatId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("StatName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("StatId");

                    b.ToTable("Stat");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("UserId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.UserType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("varchar(24)");

                    b.HasKey("Id");

                    b.ToTable("UserType");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Hero", b =>
                {
                    b.HasBaseType("svelte_rpg_backend.Models.Actor");

                    b.Property<int>("Exp")
                        .HasColumnType("int");

                    b.Property<int>("PerkPoints")
                        .HasColumnType("int");

                    b.Property<int>("StatPoints")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasIndex("UserId");

                    b.ToTable("Hero", (string)null);
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Monster", b =>
                {
                    b.HasBaseType("svelte_rpg_backend.Models.Actor");

                    b.Property<int>("MonsterCatalogId")
                        .HasColumnType("int");

                    b.HasIndex("MonsterCatalogId");

                    b.ToTable("Monster", (string)null);
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ActorAttribute", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Actor", null)
                        .WithMany("Attributes")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Attribute", "Attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.MonsterCatalog", null)
                        .WithMany("Attributes")
                        .HasForeignKey("MonsterCatalogId");

                    b.Navigation("Attribute");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ActorStat", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Actor", null)
                        .WithMany("Stats")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.MonsterCatalog", null)
                        .WithMany("Stats")
                        .HasForeignKey("MonsterCatalogId");

                    b.HasOne("svelte_rpg_backend.Models.Stat", "Stat")
                        .WithMany()
                        .HasForeignKey("StatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stat");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.AttributeStatsRatio", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Attribute", "Attributes")
                        .WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Stat", "Stats")
                        .WithMany()
                        .HasForeignKey("StatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attributes");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.BattleState", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Hero", "Hero")
                        .WithMany()
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Monster", "Monster")
                        .WithMany()
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hero");

                    b.Navigation("Monster");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.HeroEquipment", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.EquipmentSlot", "EquipmentSlot")
                        .WithMany()
                        .HasForeignKey("EquipmentSlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Hero", null)
                        .WithMany("HeroEquipments")
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EquipmentSlot");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Item", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.ItemCatalog", "ItemCatalog")
                        .WithMany()
                        .HasForeignKey("ItemCatalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemCatalog");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ItemAttribute", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Attribute", "Attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Item", null)
                        .WithMany("ItemAttributes")
                        .HasForeignKey("ItemId1");

                    b.Navigation("Attribute");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ItemCatalog", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.ActionText", "ActionText")
                        .WithMany()
                        .HasForeignKey("ActionTextId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.ItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Rarity", "Rarity")
                        .WithMany()
                        .HasForeignKey("RarityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActionText");

                    b.Navigation("ItemType");

                    b.Navigation("Rarity");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ItemLoot", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Loot", null)
                        .WithMany("ItemLoot")
                        .HasForeignKey("LootId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ItemSlot", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Hero", null)
                        .WithMany("ItemSlots")
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.ItemStat", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Item", null)
                        .WithMany("ItemStats")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Stat", "Stat")
                        .WithMany()
                        .HasForeignKey("StatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stat");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.MonsterLoot", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Loot", "Loot")
                        .WithMany()
                        .HasForeignKey("LootId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Monster", null)
                        .WithMany("MonsterLoots")
                        .HasForeignKey("MonsterActorId");

                    b.HasOne("svelte_rpg_backend.Models.MonsterCatalog", null)
                        .WithMany("MonsterLoots")
                        .HasForeignKey("MonsterCatalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loot");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Perk", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Hero", null)
                        .WithMany("Perks")
                        .HasForeignKey("HeroActorId");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.PerkAttribute", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Attribute", "Attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Perk", null)
                        .WithMany("AttributesChanged")
                        .HasForeignKey("PerkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attribute");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.PerkStat", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Perk", null)
                        .WithMany("StatsChanged")
                        .HasForeignKey("PerkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Stat", "Stat")
                        .WithMany()
                        .HasForeignKey("StatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stat");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Skill", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.ActionText", "ActionText")
                        .WithMany()
                        .HasForeignKey("ActionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.Hero", null)
                        .WithMany("Skills")
                        .HasForeignKey("HeroActorId");

                    b.HasOne("svelte_rpg_backend.Models.SkillType", "SkillType")
                        .WithMany()
                        .HasForeignKey("SkillTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActionText");

                    b.Navigation("SkillType");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.User", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.UserType", "UserType")
                        .WithMany()
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Hero", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Actor", null)
                        .WithOne()
                        .HasForeignKey("svelte_rpg_backend.Models.Hero", "ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.User", null)
                        .WithMany("Heroes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Monster", b =>
                {
                    b.HasOne("svelte_rpg_backend.Models.Actor", null)
                        .WithOne()
                        .HasForeignKey("svelte_rpg_backend.Models.Monster", "ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("svelte_rpg_backend.Models.MonsterCatalog", "MonsterCatalog")
                        .WithMany()
                        .HasForeignKey("MonsterCatalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MonsterCatalog");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Actor", b =>
                {
                    b.Navigation("Attributes");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Item", b =>
                {
                    b.Navigation("ItemAttributes");

                    b.Navigation("ItemStats");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Loot", b =>
                {
                    b.Navigation("ItemLoot");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.MonsterCatalog", b =>
                {
                    b.Navigation("Attributes");

                    b.Navigation("MonsterLoots");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Perk", b =>
                {
                    b.Navigation("AttributesChanged");

                    b.Navigation("StatsChanged");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.User", b =>
                {
                    b.Navigation("Heroes");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Hero", b =>
                {
                    b.Navigation("HeroEquipments");

                    b.Navigation("ItemSlots");

                    b.Navigation("Perks");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("svelte_rpg_backend.Models.Monster", b =>
                {
                    b.Navigation("MonsterLoots");
                });
#pragma warning restore 612, 618
        }
    }
}
