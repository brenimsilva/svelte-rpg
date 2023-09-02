<script>
	import Menu from "../components/Menu.svelte";
import "./style.css"
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
                <slot />
                <Menu />
            </div>
        </main>
    </div>
    <footer>
        <p>Author:</p>
       <p>Breno Almeida</p>
    </footer>
</body>

<style scoped>
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
        /* background-image: url("../assets/yrkGs9.png"); */
        /* background-repeat: no-repeat; */
        /* background-size: cover; */
        /* background-position: center; */
        background-color: #333;
        padding: 20px;
    }
    main {
        background-image: url("../assets/texture.png");
        background-color: #c6baa1;
        background-repeat: no-repeat;
        background-size: auto;
        background-position: center;
        display: flex;
        justify-content: center;
        align-items: center;
        padding: 20px;
        width: 600px;
        height: 750px;
    }
    .content {
        display: flex;
        justify-content: center;
        align-items: center;
        box-shadow: 0 1px 3px black;
        min-height: 90%;
    }
    .content {
        height: 300px;
        max-height: 300px;
        padding: 20px;
        width: 100vw;
        overflow: hidden;
    }
</style>