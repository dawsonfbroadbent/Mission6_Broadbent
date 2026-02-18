using Microsoft.EntityFrameworkCore;

namespace Mission6_Broadbent.Models;

public class MovieRatingsContext : DbContext
{
    //Constructor to Set up Options
    public MovieRatingsContext(DbContextOptions<MovieRatingsContext> options) :  base(options) 
    {
        
    }
    
    public DbSet<MovieRating> Movies { get; set; }
    public DbSet<Category> Categories { get; set; }

}