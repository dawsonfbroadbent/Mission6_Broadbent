using Microsoft.EntityFrameworkCore;

namespace Mission6_Broadbent.Models;

public class MovieRatingsContext : DbContext
{
    //Constructor to Set up Options
    public MovieRatingsContext(DbContextOptions<MovieRatingsContext> options) :  base(options) 
    {
        
    }
    
    public DbSet<MovieRating> MovieRatings { get; set; }
}