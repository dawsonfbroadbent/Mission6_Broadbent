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
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
        
        return View(new MovieRating());
    }

    [HttpPost]
    public IActionResult AddMovies(MovieRating response)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
                    
            return View("Confirmation", response);
        }
        else
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            
            return View(response);
        }
    }
    
    public IActionResult ViewMovies()
    {
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
        
        var ratings = _context.Movies
            .OrderBy(x => x.Title).ToList();
        return View(ratings);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var recordToEdit = _context.Movies
            .Single(x => x.MovieId == id);
        
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
        
        return View("AddMovies", recordToEdit);
    }

    [HttpPost]
    public IActionResult Edit(MovieRating updatedInfo)
    {
        _context.Update(updatedInfo);
        _context.SaveChanges();
        return RedirectToAction("ViewMovies");
    }
    
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var recordToDelete = _context.Movies
            .Single(x => x.MovieId == id);
        
        ViewBag.Categories = _context.Movies
            .OrderBy(x => x.Title)
            .ToList();
        
        return View(recordToDelete);
    }

    [HttpPost]
    public IActionResult Delete(MovieRating deletedInfo)
    {
        _context.Movies.Remove(deletedInfo);
        _context.SaveChanges();
        return RedirectToAction("ViewMovies");
    }
}