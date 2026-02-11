using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_Broadbent.Models;

namespace Mission6_Broadbent.Controllers;

public class HomeController : Controller
{
    private MovieRatingsContext _context;
    
    public HomeController(MovieRatingsContext someName) //Constructor
    {
        _context = someName;
    }
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult AddMovies()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddMovies(MovieRating response)
    {
        _context.MovieRatings.Add(response);
        _context.SaveChanges();
        return View("Confirmation", response);
    }
}