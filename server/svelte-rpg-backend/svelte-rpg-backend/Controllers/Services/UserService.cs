using svelte_rpg_backend.Models;

namespace svelte_rpg_backend.Services;

public class UserService
{
   public UserService()
   {
      
   }

   public async Task<User> GetByUsername(string username)
   {
      return new User();
   }
}