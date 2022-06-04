using ChatApp.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.ViewComponents
{
    public class HeadingViewComponent : ViewComponent
    {
        private AppDbContext _ctx;
        public HeadingViewComponent(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
