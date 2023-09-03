<script lang="ts">
	import BattleLog from "../../components/BattleLog.svelte";
import Stats from "../../components/Stats.svelte";
	import type { IPlayer } from "../../components/player";
	import Player from "../../components/player";

    let player = new Player({atk: 1, def: 0, hp: 10, mp: 0}, {agi: 0, dex: 0, int: 0, vit: 0}, 1, {height: 1, url: "assets/char1nobg.png", width: 1});
    let monster = new Player({atk: 1, def: 0, hp: 10, mp: 0}, {agi: 0, dex: 0, int: 0, vit: 0}, 1, {height: 1, url: "assets/rat01.png", width: 1});
</script>

<div class="container">
    <Stats player={monster} isMonster={true}/>
    <Stats player={player} isMonster={false}/>
    <div class="log_container">
        <BattleLog />
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
