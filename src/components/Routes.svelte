    <main class="routes_menu">
        <h1 class="title">Routes</h1>
        <div class="">
            <a href="/battle" class="action">Battle</a>
            <a href="/save" class="action">Save</a>
            <a href="/training" class="action">Training</a>
        </div>
        <div>
            <a href="/stats" class="action">Stats</a>
            <a href="/equipment" class="action">Equipments</a>
            <a href="/shop" class="action">Shop</a>
        </div>
    </main>
    <style scoped>
    .routes_menu {
        box-sizing: border-box;
        height: 150px;
        padding: 10px;
        display: grid;
        grid-template-rows: 1fr 1fr 1fr;
        width: 100%;
        gap: 10px;
        box-shadow: 0 2px 3px rgba(0, 0, 0, 0.486);
        border-radius: 24px;
    }
    .action {
        border: 1px solid black;
        padding: 10px;
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