<script>
	import Actions from "../components/Actions.svelte";
	import Menu from "../components/Menu.svelte";
	import Routes from "../components/Routes.svelte";
	import Scene from "../components/Scene.svelte";
    import "./style.css"

    let isFighting  = true;
</script>
<head>
    <title>RPG Game</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css" integrity="sha512-z3gLpd7yknf1YoNbCzqRKc4qyor8gaKU1qmn+CShxbuBusANI9QpRohGBreCFkKxLhei6S9CQXFEbbKuqLg0DA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</head>
<body>
    <nav>
        <a href="/">Home</a>
    </nav>
    <div id="app">
        <main>
            <div class="content">
                <div class="container">
                    <div id="scene">
                        <slot />
                    </div>
                    <Routes />
                    <div class="fight_container">
                    {#if isFighting}
                        <Actions />
                    {/if}
                    </div>
                </div>
            </div>
        </main>
    </div>
    <footer>
        <p>Author:</p>
       <p>Breno Almeida</p>
    </footer>
</body>

<style scoped>
    #scene {
        /* display: flex; */
        height: 310px;
        box-sizing: border-box;
        padding: 10px;
        width: 100%;
        box-shadow: 0 1px 3px rgba(0, 0, 0, 0.522);
        /* background-color: #c3a66769; */
    }
    nav {
        background-color: black;
        padding: 5px;
    }
    nav > a {
        text-decoration: none;
        color: blue;
    }
    nav >a:visited {
        text-decoration: none;
        color: blue;
    }
    nav > a:hover {
        color: rgba(0, 0, 255, 0.671);
    }
    nav > a:hover::after {
        position:absolute;
        top: 32px;
        left: 20px;
        width: 40px;
        content: "";
        padding: 1px;
        background-color: red;
        transition: all 0.2s;
    }
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
    footer {
        background-color: black;
        color: white;
        text-align: center;
        padding: 5px;
        font-size: small;
    }
    #app {
        display: flex;
        justify-content: center;
        background-color: #333;
        padding: 20px;
    }
    main {
        background-image: url("assets/texture.png");
        background-color: #c6baa1;
        background-repeat: no-repeat;
        background-size: auto;
        background-position: center;
        display: flex;
        justify-content: center;
        align-items: center;
        padding: 20px;
        width: 500px;
        height: 750px;
    }
    .content {
        display: flex;
        justify-content: center;
        align-items: flex-end;
        box-shadow: 0 1px 3px black;
        min-height: 700px;
        max-height: 700px;
        padding: 20px;
        width: 100vw;
        overflow: hidden;
    }
</style>