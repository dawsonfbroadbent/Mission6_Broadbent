using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Mission6_Broadbent.Models;

public class MovieRating
{
    [Key]
    public int MovieId { get; set; }
    
    [Required(ErrorMessage = "Movie must have a title")]
    public string Title { get; set; }

    [Range(1888, int.MaxValue, ErrorMessage = "Enter a valid year (1888 or later).")]
    public int Year { get; set; }

    public string? Director { get; set; }

    [ForeignKey("CategoryId")]
    public int? CategoryId {  get; set; }
    public Category? CategoryName { get; set; }

    
    public string? Rating { get; set; }

    [Required(ErrorMessage = "You must enter if the movie has been edited.")]
    public int Edited { get; set; }

    // Optional
    public string? LentTo { get; set; }
    
    //Required
    [Required(ErrorMessage = "You must enter if the movie has been copied to Plex.")]
    public int CopiedToPlex { get; set; }

    // Optional, max 25 chars
    [StringLength(25)]
    public string? Notes { get; set; }
}