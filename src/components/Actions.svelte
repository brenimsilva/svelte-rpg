<script lang="ts">
	import type Battle from "../classes/Battle";
	import type Player from "../classes/Player";
    import {battleW, playerMonsterW} from "../stores/Store";
    let potionQtd = 5;
    let potionCure = 10;
    let skillName = "Imbue"
    let skillPower = 2;
    let stabPower = 5;
    let stabMinPower = 2;
    let stabChance = 90;
    let slashMinPower = 3;
    let slashPower = 8;
    let slashChance = 80;
    function fn() {
        $battleW.turn();
    }
    let player: Player;
    let monster: Player;

    playerMonsterW.subscribe(prev => {
        player = prev.player;
        monster = prev.monster;
    })
</script>
<div class="fight_menu">
    <button class="fight_action" id="slash_action" on:click={fn}>
        <a href="{void(0)}">Slash</a>
        <p class="attack_info"><img width="30" height="30" src="https://img.icons8.com/ios-glyphs/30/sword.png" alt="sword"/> {player.stats.atk} - {slashPower} ({slashChance}%)</p>
    </button>
    <button class="fight_action" id="skill_action">
        <a href="{void(0)}" class="">Skill</a>
        <p>{skillName} ({skillPower})</p>
    </button>
    <button class="fight_action" id="stab_action">
        <a href="{void(0)}" class="">Stab</a>
        <p class="attack_info"><img width="30" height="30" src="https://img.icons8.com/ios-glyphs/30/sword.png" alt="sword"/> {stabMinPower} - {stabPower} ({stabChance}%)</p>
    </button>
    <button class="fight_action" id="potion_action">
        <a href="{void(0)}" class="">Potion</a>
        <p>Qtd: {potionQtd} / Cure: ({potionCure})</p>
    </button>
</div>
<style>
    #slash_action {
        border-top-left-radius: 15px;
    }
    #slash_action:hover {
        background-color: rgba(58, 64, 58, 0.40);
    }
    #slash_action:active {
        background-color: rgba(58, 64, 58, 0.20);
    }
    #stab_action {
        border-bottom-left-radius: 15px;
    }
    #stab_action:hover {
        background-color: rgba(58, 64, 58, 0.40);
    }
    #stab_action:active {
        background-color: rgba(58, 64, 58, 0.20);
    }
    #skill_action {
        border-top-right-radius: 12px;
        background-color: #89986abb;
    }
    #skill_action:hover {
        background-color: #89986a80;
    }
    #skill_action:active {
        background-color: #89986a41;
    }
    #potion_action {
        border-bottom-right-radius: 12px;
        background-color: rgba(0, 140, 255, 0.499);
    }
    #potion_action:hover {
        background-color: rgba(0, 140, 255, 0.349);
    }
    #potion_action:active {
        background-color: rgba(0, 140, 255, 0.159);
    }
    .attack_info {
        display: flex;
        align-items: center;
    }
    .fight_action {
        padding: 15px;
        box-shadow: 1px 1px 3px rgba(0, 0, 0, 0.507);
        background-color: rgba(169, 173, 169, 0.399);
        transition: all 0.2s;
        user-select: none;
        border: none;
    }
    .fight_action:hover {
        cursor: pointer;
    }

    .fight_menu {
        display: grid;
        grid-template-columns: 1fr 1fr;
        gap: 10px;
        box-shadow: 0px 0px 5px rgba(0, 0, 0, 0.517);
        padding: 5px;
        border-radius: 12px;
    }
</style>
