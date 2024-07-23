using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext contect)
        {
            _context = contect;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Actors.ToListAsync();
            return View();
        }
    }
}
