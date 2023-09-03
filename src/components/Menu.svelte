<script lang="ts">
	import Actions from "./Actions.svelte";
	import Routes from "./Routes.svelte";
	import Scene from "./Scene.svelte";
    export let isFighting = true;
</script>

<div class="container">
    <Scene />
    <Routes />
    <div class="fight_container">
    {#if isFighting}
        <Actions />
    {/if}
    </div>
</div>

<style>
    .container {
        width: 100%;
        display: flex; 
        justify-content: center;
        align-items: center;
        flex-direction: column;
    }
    .fight_container {
        display: flex;
        flex-direction: column;
        justify-content: space-around;
        padding: 20px;
        gap: 10px;
        width: 100%;
        height: 200px;
    }
</style>
