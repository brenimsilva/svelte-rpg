	import Player, { type IAttributes, type ILevelSystem, type ISprite, type IStats } from "../../classes/Player";
    import {battleW, playerMonsterW} from "../../stores/Store"
	import Battle from "../../classes/Battle";

    const p_stats: IStats = {atk: 1, def: 0, hp: 10, max_hp: 10, evs: 0, crtc: 0, crtd: 0};
    const p_attributes: IAttributes = {agi: 0, dex: 0, vit: 0, str: 0};
    const p_sprite: ISprite =  {height: 1, url: "assets/char1nobg.png", width: 1};
    const p_levelSystem: ILevelSystem = {ap: 0, exp: 3, exp_next_level: 10, level: 1, pp: 0, sp: 0};
    let player = new Player("Hero", p_stats, p_attributes, p_sprite, p_levelSystem );

    const m_stats: IStats = {atk: 1, def: 0, hp: 10, max_hp: 10, evs: 0, crtc: 0, crtd: 0};
    const m_attributes: IAttributes = {agi: 0, dex: 0, vit: 0, str: 0};
    const m_sprite: ISprite =  {height: 1, url: "assets/rat01.png", width: 1};
    const m_levelSystem: ILevelSystem = {ap: 0, exp: 10, exp_next_level: 10, level: 1, pp: 0, sp: 0};
    let monster = new Player("Rat", m_stats, m_attributes, m_sprite, m_levelSystem);
    let b = new Battle(player, monster);
    battleW.set(b);
    playerMonsterW.set({player,monster});