<script lang="ts">

</script>

<div class="container">
    <h1 class="title">Actions</h1>
    <div>
        <a href="{void(0)}" class="action">Attack</a>
        <a href="{void(0)}" class="action">Skill</a>
        <a href="{void(0)}" class="action">Item</a>
    </div>
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
    .container {
        display: flex;
        flex-direction: column;
        justify-content: space-around;
        box-shadow: 0 2px 3px rgba(0, 0, 0, 0.382);
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
