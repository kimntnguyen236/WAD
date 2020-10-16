using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab10.Models;

namespace Lab10.Controllers
{
    public class vSkillProgrammersController : Controller
    {
        private readonly ProgrammerContext _context;

        public vSkillProgrammersController(ProgrammerContext context)
        {
            _context = context;
        }

        // GET: vSkillProgrammers
        public async Task<IActionResult> Index()
        {
            return View(await _context.vSkillProgrammer.ToListAsync());
        }

    }
}
