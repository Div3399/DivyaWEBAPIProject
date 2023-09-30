﻿using Hospital.Models;
using Hospital.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Utilities
{
    public class Dbinitializer : IDbIntializer
    {
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private ApplicationDbContext _context;

        public Dbinitializer(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public void Initalizer()
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Count() >= 0)
                {
                    _context.Database.Migrate();
                }

            }
            catch (Exception)
            {
                throw;
            }
            if (!_roleManager.RoleExistsAsync(WebsiteRoles.Website_Admin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(WebsiteRoles.Website_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebsiteRoles.Website_Patient)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebsiteRoles.Website_Doctor)).GetAwaiter().GetResult();

                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "Divya",
                    Email = "sscv123@.com"
                },"Divya@123").GetAwaiter().GetResult();
               
                var Appuser = _context.ApplicationUsers.FirstOrDefault(x=>x.Email== "SS@1233.com");
                
                if(Appuser != null) 
                {
                    _userManager.AddToRoleAsync(Appuser, WebsiteRoles.Website_Admin).GetAwaiter().GetResult();
                }



            }
        }
    }
}
