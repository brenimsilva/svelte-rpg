    <main class="routes_menu">
            <a href="/battle" class="action">Battle</a>
            <a href="/save" class="action">Save</a>
            <a href="/training" class="action">Training</a>
            <a href="/stats" class="action">Stats</a>
            <a href="/equipment" class="action">Equipments</a>
            <a href="/shop" class="action">Shop</a>
    </main>
    <style scoped>
        .row {
            display: flex;
            justify-content: center;
            align-items: center;
            gap: 10px;
        }
    .routes_menu {
        display: grid;
        grid-template-columns: 1fr 1fr 1fr;
        box-sizing: border-box;
        height: 150px;
        width: 100%;
        padding: 5px;
        gap: 5px;
        box-shadow: 0 2px 3px rgba(0, 0, 0, 0.486);
        /* border-radius: 24px; */
    }
    .action {
        border: 1px solid black;
        padding: 10px;
        cursor: pointer;
        text-decoration: none;
        transition: all 0.2s ease;
        color: black;
        user-select: none;
        display: flex;
        justify-content: center;
        align-items: center;
    }
    .action:hover {
        background-color: rgba(128, 128, 128, 0.63);
        color: white;
    }
    .action:active {
        background-color: rgba(128, 128, 128, 0.525);
    }
    .title {
        font-size: 20px;
    }
    </style>