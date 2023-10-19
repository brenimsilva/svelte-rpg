using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models;
using Microsoft.EntityFrameworkCore;
namespace svelte_rpg_backend.Services;

public class AuthService 
{
    RpgContext _ctx;
    
    public AuthService(RpgContext ctx) {
        this._ctx = ctx;
    }

    // public async Task<User> LogIn(string usuario, string senha)
    // {
    //     string senhaCrypto = Util.StringUtilities.Hash(senha);
    //     User u = await _ctx.User.Include(e => e.Token).FirstOrDefaultAsync(e => e.UserName == usuario && e.Password == senhaCrypto);
    //     var t = await SetToken(u);
    //     
    //     return u;
    // }

    // public async Task<bool> CheckToken(string token) {
    //     Token t = await _ctx.Token.FirstOrDefaultAsync(e => e.token == token);
    //     if(t.expires_at > DateTime.Now) {
    //         return true;
    //     }
    //     return false;
    // }
    //
    // public async Task<Token> SetToken(User user) {
    //     Guid randomguid = Guid.NewGuid();
    //     Token t = new Token()
    //     {
    //         TokenId = 0,
    //         token = randomguid.ToString(),
    //         expires_at = DateTime.Now.AddMinutes(5),
    //         UserId = user.UserId
    //     };
    //     await _ctx.Token.AddAsync(t);
    //     return t;
    // }

}
