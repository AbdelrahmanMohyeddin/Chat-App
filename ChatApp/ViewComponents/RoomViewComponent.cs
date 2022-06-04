using System.Linq;
using System.Security.Claims;
using ChatApp.Database;
using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.ViewComponents
{
    public class RoomViewComponent : ViewComponent
    {
        private AppDbContext _ctx;
        public RoomViewComponent(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public IViewComponentResult Invoke()
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var chats = _ctx.Chats
            .Include(x => x.Users)
            .ThenInclude(x => x.User)
            .Where(x => x.Users
             .Any(y => y.UserId == userId))
             .ToList();
            return View(chats);
        }
    }
}