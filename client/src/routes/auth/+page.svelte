<script lang="ts">
let passwordInput = '';
let usernameInput = '';

$: console.log(passwordInput);

</script>

<div>
    <form>
        <h4> Login </h4>
        <input type="text" bind:value={usernameInput} />
        <h4> Password </h4>
        <input type="password" bind:value={passwordInput} />
        <input type="button" value="Logar" on:click={ async (e) => {
            const fd = new FormData();
            fd.append("usuario", usernameInput);
            fd.append("senha", passwordInput);
            console.log(fd.get('usuario'))
            const user = await fetch("https://localhost:7062/Auth", {method: "POST", body:fd })
            const json = await user.json();
            console.log(json);
        }}>
    </form>
</div>
