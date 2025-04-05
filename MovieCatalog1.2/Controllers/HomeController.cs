using Microsoft.AspNetCore.Mvc;
using MovieCatalog1._2.Data;  // Ensure this is the correct namespace for your ApplicationDbContext
using Microsoft.EntityFrameworkCore;
using MovieCatalog1._2.Data.Models;
using Microsoft.Extensions.Logging;
using MovieCatalog1._2.Models;
using System.Diagnostics;

namespace MovieCatalog1._2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        // Constructor to inject the ApplicationDbContext
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;  // Add context to fetch movies from the database
        }

        // Home page Index action
        public async Task<IActionResult> Index()
        {
            // Fetch all movies from the database
            var movies = await _context.Movies.ToListAsync();
            return View(movies);  // Pass the movie list to the view
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
