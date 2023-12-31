﻿using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Models.DTO;
using svelte_rpg_backend.Models.Enums;
using svelte_rpg_backend.Util;

namespace svelte_rpg_backend.Services;

public class UserService
{
   private RpgContext _context;
   public UserService(RpgContext rpgContext)
   {
       this._context = rpgContext;
   }

   // public async Task<User> GetByGuid(Guid guid)
   // {
   //     var userHeroes = await _context.Hero.Where(h => h.UserGuid == guid).ToListAsync();
   //     return userHeroes;
   // }

   // public async Task<User> Add(UserDTO user)
   // {
   //          string hash = StringUtilities.Hash(user.Password);
   //          User createdUser = new User()
   //          {
   //              created_at = DateTime.Now,
   //              Heroes = new List<Hero>(),
   //              updated_at = DateTime.Now,
   //              UserTypeId = (int)UserTypeEnum.Player,
   //          };
   //          _context.User.Add(createdUser);
   //          await _context.SaveChangesAsync();
   //          return createdUser;
   // }

   // public async Task<User> UpdateUser(string username, JsonPatchDocument<User> userPatch)
   // {
   //     var user = await _context.User.FindAsync(username);
   //     if (user != null)
   //     {
   //         userPatch.ApplyTo(user);
   //         await _context.SaveChangesAsync();
   //     }
   //     return user;
   // }
    
}