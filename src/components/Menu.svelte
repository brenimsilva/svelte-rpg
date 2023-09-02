<script lang="ts">
	import Actions from "./Actions.svelte";
	import Routes from "./Routes.svelte";
</script>

<div class="container">
    <Routes />
    <Actions />
</div>

<style>
    .container {
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
    }
</style>
