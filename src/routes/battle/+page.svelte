<script lang="ts">
	import Stats from "../../components/Stats.svelte";
	import type { IPlayer } from "../../components/player";

    let player: IPlayer = {attributes:{agi: 0, dex: 0, int: 0, vit: 0}, sp: 1, stats: {atk: 1, def: 0, hp: 10, mp: 0}}
    let monster: IPlayer = {...player};
</script>

<div class="container">
    <Stats player={player}/>
    <Stats player={monster}/>
</div>

<style>
    .container {
        display: flex;
    }
</style>
