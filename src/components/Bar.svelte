<script lang="ts">
    export let stat : number
    export let max_stat: number;
    export let color: string;
    let stat_percentage: number;
    $:  {
        stat_percentage = (stat * 100) / max_stat
    }
    
</script>

<div class="outer">
    <div class="inner" style="width: {stat_percentage}%; background-color: {color};"></div>
</div>

<style scoped>
    .outer {
        width: 100%px;
        height: 8px;
        background-color: #333;
        border-radius: 6px;
        overflow: hidden;
    }
    .inner {
        transition: all 0.2s;
        height: 100%;
    }
</style>

