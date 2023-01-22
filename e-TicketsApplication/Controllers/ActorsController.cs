using e_TicketsApplication.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_TicketsApplication.Controllers
{
    public class ActorsController : Controller
    {
        public async Task<IActionResult> Index()
        {

            return View(await _context.Actors.ToListAsync());
        }
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        /*
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View();
        }
        */
    }
}
