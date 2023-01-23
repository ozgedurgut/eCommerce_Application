using e_TicketsApplication.Data;
using e_TicketsApplication.Data.Services;
using e_TicketsApplication.Models;
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
        private readonly IActorsService _service;
        
        public async Task<IActionResult> Index()
        {

            return View(await _service.GetAll());
        }
        
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        //Get: Actors/Create
        public  IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Fullname,ProfilePictureURL,Bio")]Actor actor) 
        {
            if (!ModelState.IsValid) 
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
