<script lang="ts">
	import BattleLog from "../../components/BattleLog.svelte";
    import Stats from "../../components/Stats.svelte";
	import Player, { type IAttributes, type ILevelSystem, type ISprite, type IStats } from "../../classes/Player";
	import type { BattleLogType } from "../../classes/Types";
    import {battleLogW} from "../../stores/Store"
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
    let battleLog: BattleLogType[];
    battleLogW.subscribe(prev => battleLog = prev);
    const b = new Battle(player, monster);
    function fn() {
       const updated = b.turn();
       player = updated.player;
       monster = updated.monster;
    }
</script>

<div class="container">
    <button on:click={fn}>a</button>
    <Stats player={monster} isMonster={true}/>
    <Stats player={player} isMonster={false}/>
    <div class="log_container">
        <BattleLog logs={battleLog} />
    </div>
</div>

<style>
    .container {
        display: flex;
        flex-direction: column;
        max-height: 200px;
        gap: 5px;
    }
    .log_container {
        background-color: rgba(59, 48, 48, 0.47);
        color: white;
        font-size: 12px;
        border-radius: 12px;
        box-shadow: 0 2px 3px rgba(0, 0, 0, 0.446);
        padding: 10px;
        min-height: 35px;
        overflow: auto;
        display: flex;
        justify-content: center;
        align-items: center;
    }
</style>
