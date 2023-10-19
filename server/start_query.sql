BEGIN;
INSERT INTO `svelte-rpg`.UserType
VALUES
	(1, 'Spectator'),
	(2, 'Player'),
	(3, 'Premium Player'),
	(4, 'Moderator'),
	(5, 'Admin');

INSERT INTO `svelte-rpg`.Stat
VALUES
    (1,'STR','Strength','Represents the physical power and muscle strength of a character, influencing Attack and Max Health Points'),
    (2,'VIT','Vitality','Denotes the overall health and endurance of a character, affecting Max Health Points and Defense'),
    (3,'DEX','Dexterity','Signifies a character\'s finesse, precision, and hand-eye coordination, influencing Defense and Critical Damage'), (4,'AGI','Agility','Reflects a character\'s speed, reflexes, and nimbleness, affecting Evasion Rate');

INSERT INTO `svelte-rpg`.Attribute
VALUES
('1', 'HP', 'Health Points', 'Represents the current health of a character or entity in a game or simulation, indicating how much damage it can withstand before being defeated'),
('2', 'MHP', 'Max Health Points', 'Denotes the maximum potential health a character or entity can have, setting an upper limit on their survivability'),
('3', 'ATK', 'Attack', 'Signifies the offensive strength or damage-dealing capability of a character, determining the harm it inflicts on opponents'),
('4', 'DEF', 'Defense', 'Reflects the defensive capabilities of a character, reducing the damage taken from incoming attacks and enhancing overall resilience'),
('5', 'EVS', 'Evasion', 'Represents a character\'s ability to dodge or evade incoming attacks, reducing the likelihood of being hit'),
('6', 'CRTC', 'Critical Chance', 'Indicates the probability or likelihood of a character landing a critical hit, which typically results in increased damage'),
('7', 'CRTD', 'Critical Damage', 'Specifies the additional damage multiplier applied when a critical hit occurs, amplifying the impact of such attacks');

INSERT INTO `svelte-rpg`.AttributeStatRatio
VALUES
('1', '2', '2', '5'),
('2', '1', '2', '1.5'),
('3', '1', '3', '2'),
('4', '3', '4', '0.5'),
('5', '3', '7', '1'),
('6', '2', '4', '1'),
('7', '4', '5', '1');

INSERT INTO `svelte-rpg`.SkillType
VALUES
    (1,'Buff','A Skill that increases your power'),
    (2,'Offensive','A Offensive skill that deals damage'),
    (3,'Cure','This skill will heal your HP');
INSERT INTO `svelte-rpg`.Rarity
VALUES
    (1, 'Common', 'Items with this rarity level are easily found and typically have basic attributes or abilities. They are often used for basic purposes in the game', '#FFFFFF'),
    (2, 'Uncommon', 'Uncommon items are somewhat harder to come by than common ones. They offer slightly improved attributes or unique features, making them more valuable to players.', '#119100'),
    (3, 'Rare', 'Rare items are relatively scarce and offer significant enhancements or unique abilities. Players often seek these items for their substantial benefits', '#004180'),
    (4, 'Epic', 'Epic items are exceptionally rare and possess extraordinary attributes or abilities. They are highly coveted by players and can be game-changing', '#9400f7'),
    (5, 'Master Work', 'Master Work items are expertly crafted and represent the pinnacle of item quality. They provide exceptional advantages and are considered prized possessions by players', '#f7c010'),
    (6, 'Legendary', 'Legendary items are the rarest and most powerful items in the game. They possess legendary abilities, unique effects, or unparalleled stats, making them the most sought-after and prestigious items', '#f7033c');

-- =====MONSTER=====
INSERT INTO `svelte-rpg`.MonsterCatalog
VALUES
    (1, 'Rat', 1, NOW(), NOW());

INSERT INTO `svelte-rpg`.MonsterStat
VALUES
    (0, 1, 1, 1),
    (0, 2, 1, 5),
    (0, 3, 1, 1);
INSERT INTO `svelte-rpg`.MonsterAttribute
VALUES
    (0, 1, 1, 11.5),
    (0, 2, 1, 11.5),
    (0, 3, 1, 3.5),
    (0, 4, 1, 1),
    (0, 5, 1, 1),
    (0, 6, 1, 1),
    (0, 7, 1, 1);
INSERT INTO `svelte-rpg`.ItemType
VALUES
    ('1', 'Equipment', 'A Item that can be equipped (Check slot)'),
    ('2', 'Consumable', 'A Item that can be consumable during fight'),
    ('3', 'Miscellaneous', 'Maybe it has some value at the shop...'),
    ('4', 'Gem', 'With this Item you can upgrade your equipments');

-- =====ITEM=====
INSERT INTO  `svelte-rpg`.ActionText
VALUES
    (1, 'Stabbed');

INSERT INTO  `svelte-rpg`.ItemCatalog
VALUES
    (1, 'Wooden Sword', 'A sword made of wood', 1,1,1);

INSERT INTO `svelte-rpg`.EquipmentSlot
VALUES
('1', 'Head'),
('2', 'Chest'),
('3', 'Main Hand'),
('4', 'Off Hand'),
('5', 'Ring'),
('6', 'Neck'),
('7', 'Feet'),
('8', 'Waist'),
('9', 'Back'),
('10', 'Shoulder'),
('11', 'Wrist'),
('12', 'Hands'),
('13', 'Leg'),
('14', 'Ears');

COMMIT;
