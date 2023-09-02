<script lang="ts">
    export let isFighting = true;
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
</script>

<div class="container">
    {#if isFighting}
        <div class="fight_menu">
            <div class="fight_action" id="slash_action">
                <a href="{void(0)}" class="">Slash</a>
                <p class="attack_info"><img width="30" height="30" src="https://img.icons8.com/ios-glyphs/30/sword.png" alt="sword"/> {slashMinPower} - {slashPower} ({slashChance}%)</p>
            </div>
            <div class="fight_action" id="skill_action">
                <a href="{void(0)}" class="">Skill</a>
                <p>{skillName} ({skillPower})</p>
            </div>
            <div class="fight_action" id="stab_action">
                <a href="{void(0)}" class="">Stab</a>
                <p class="attack_info"><img width="30" height="30" src="https://img.icons8.com/ios-glyphs/30/sword.png" alt="sword"/> {stabMinPower} - {stabPower} ({stabChance}%)</p>
            </div>
            <div class="fight_action" id="potion_action">
                <a href="{void(0)}" class="">Potion</a>
                <p>Qtd: {potionQtd} / Cure: ({potionCure})</p>
            </div>
        </div>
    {/if}
    <h1 class="title">Routes</h1>
    <div>
        <a href="/battle" class="action">Battle</a>
        <a href="/save" class="action">Save</a>
        <a href="/training" class="action">Training</a>
    </div>
    <div>
        <a href="/stats" class="action">Stats</a>
        <a href="/equipment" class="action">Equipments</a>
        <a href="/shop" class="action">Shop</a>
    </div>
</div>

<style>
    #slash_action {
        background-color: rgba(58, 64, 58, 0.50);
        border-top-left-radius: 15px;
    }
    #slash_action:hover {
        background-color: rgba(58, 64, 58, 0.40);
    }
    #slash_action:active {
        background-color: rgba(58, 64, 58, 0.20);
    }
    #stab_action {
        background-color: rgba(58, 64, 58, 0.50);
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
        background-color: rgba(0, 128, 0, 0.481) ;
    }
    #skill_action:hover {
        background-color: rgba(0, 128, 0, 0.381) ;
    }
    #skill_action:active {
        background-color: rgba(0, 128, 0, 0.181) ;
    }
    #potion_action {
        border-bottom-right-radius: 12px;
        background-color: rgba(0, 102, 255, 0.455);
    }
    #potion_action:hover {
        background-color: rgba(0, 102, 255, 0.355);
    }
    #potion_action:active {
        background-color: rgba(0, 102, 255, 0.155);
    }
    .attack_info {
        display: flex;
        align-items: center;
    }
    .fight_action {
        padding: 15px;
        box-shadow: 1px 1px 3px rgba(0, 0, 0, 0.507);
        transition: all 0.2s;
        user-select: none;
    }
    .fight_action:hover {
        cursor: pointer;
    }

    .fight_menu {
        display: grid;
        grid-template-columns: 1fr 1fr;
        gap: 5px;
        box-shadow: 0px 0px 5px rgba(0, 0, 0, 0.517);
        padding: 5px;
    }
    .container {
        display: flex;
        flex-direction: column;
        justify-content: space-around;
        padding: 20px;
        gap: 10px;
    }
    .action {
        border: 1px solid black;
        padding: 5px;
        cursor: pointer;
        text-decoration: none;
        transition: all 0.2s ease;
        color: black;
        user-select: none;
    }
    .action:hover {
        background-color: gray;
        color: white;
    }
    .action:active {
        background-color: rgba(128, 128, 128, 0.525);
    }
    .title {
        font-size: 20px;
    }
</style>
