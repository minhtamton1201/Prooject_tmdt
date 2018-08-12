using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanSach.Data;
using QuanLyBanSach.Models;

namespace QuanLyBanSach.Areas.Users.ViewComponents
{
    [Authorize(Roles = "User")]
    [ViewComponent]
    public class Sidebar : ViewComponent, IDisposable
    {
        UserManager<ApplicationUser> userManager;
        public Sidebar(ApplicationDbContext _context, UserManager<ApplicationUser> _usermanager) =>
            userManager = _usermanager;

        public void Dispose() => ((IDisposable)userManager).Dispose();

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            return View(user);
        }


    }
}