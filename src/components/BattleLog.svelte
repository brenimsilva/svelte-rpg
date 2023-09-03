<script lang="ts">
export let logs = [{from: "You", to: "Rat", action: "Attacked", ammount: 5},{from: "Rat", to: "You", action: "Attack", ammount: 2}];
</script>

<div>
    {#each logs as log}
        <p><span class="actor">{log.from}</span> {log.action} <span class="actor">{log.to}</span> with <span class="ammount">{log.ammount}</span> power</p>
    {/each}
</div>

<style scoped>
    .actor {
        color: yellow;
        filter: drop-shadow(1px 1px 3px rgb(249, 241, 26));
    }
    .ammount {
        color: rgb(3, 247, 255);
        font-weight: bold;
        filter: drop-shadow(1px 1px 3px rgb(26, 201, 249));
    }
</style>