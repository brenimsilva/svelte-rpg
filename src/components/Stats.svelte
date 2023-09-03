<script lang="ts">
	import type Player from "./player";
	import  type { IPlayer } from "./player";

    export let player: Player;
    export let charUrl = "../assets/char1bg-removebg.png";
    export let isMonster: boolean;
</script>

<div class="container {isMonster ? 'reverse' : ''}">
    <div class="stats_container">
        <div class="stats">
            <p><span>HP: </span>{player.stats.hp}</p>
            <p><span>ATK: </span>{player.stats.atk}</p>
        </div>
        <div class="stats">
            <p><span>EVS: </span>{player.stats.evs}</p>
            <p><span>DEF: </span>{player.stats.def}</p>
        </div>
        <div class="stats">
            <p><span>CRTC: </span>{player.stats.crtc}</p>
            <p><span>CRTD: </span>{player.stats.crtd}</p>
        </div>
    </div>
    <div class="image_container {isMonster ? '' : 'image_reverse'}">
        <img src={player.sprite.url} width="60px"  class="{isMonster ? '' : 'sprite_reverse'}"/> 
    </div>
</div>


<style>
    .container {
        display: flex;
        gap: 10px;
        box-sizing: border-box;
        padding: 10px;
        box-shadow: 0 2px 3px rgba(0, 0, 0, 0.364);
        background-color: rgba(222, 220, 97, 0.339);
        border: 2px solid white;
        border-radius: 12px;
        
    }
    .reverse {
        flex-direction: row-reverse;
    }
    .image_container {
       width: 100%;
       padding: 0 20px;

    }
    .image_reverse {
        text-align: end;
    }
    .stats_container {
        display: flex;
        align-items: start;
    }

    .stats > p {
        padding: 0;
        margin: 0;
    }
    .sprite_reverse {
        transform: scaleX(-1);
    }

</style>
