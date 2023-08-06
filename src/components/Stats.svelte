<script lang="ts">
	import  type { IPlayer } from "./player";

    export let player: IPlayer;
</script>

<div class="container">
    <div>
        <p><span>HP: </span>{player.stats.hp}</p>
        <p><span>MP: </span>{player.stats.mp}</p>
    </div>
    <div>
        <p><span>ATK: </span>{player.stats.atk}</p>
        <p><span>DEF: </span>{player.stats.def}</p>
    </div>
</div>


<style>
    .container {
        display: flex;
        gap: 10px;
        box-shadow: 0 2px 3px rgba(0, 0, 0, 0.364);
        padding: 10px;
    }
</style>
