<script lang="ts">
	import BattleLog from "../../components/BattleLog.svelte";
	import Stats from "../../components/Stats.svelte";
    import {playerMonsterW, battleLogW} from "../../stores/Store"
</script>

<div class="container">
    <Stats player={$playerMonsterW.monster} isMonster={true}/>
    <Stats player={$playerMonsterW.player} isMonster={false}/>
    <div class="log_container">
        <BattleLog logs={$battleLogW} />
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
