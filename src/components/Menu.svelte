<script lang="ts">
	import Actions from "./Actions.svelte";
	import Routes from "./Routes.svelte";
	import Scene from "./Scene.svelte";
</script>

<div class="container">
    <Scene />
    <Routes />
    <Actions />
</div>

<style>
    .container {
        width: 100%;
        display: flex; 
        justify-content: center;
        align-items: center;
        flex-direction: column;
    }
</style>
