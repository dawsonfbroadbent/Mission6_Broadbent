using System.ComponentModel.DataAnnotations;

namespace Mission6_Broadbent.Models;

public class MovieRating
{
    [Key]
    [Required]
    public string Title { get; set; }

    [Required]
    public int Year { get; set; }

    [Required]
    public string Director { get; set; }

    [Required]
    public string Category { get; set; }
    
    [Required]
    public string Rating { get; set; }

    // Optional yes/no (true/false). Nullable makes it "not required".
    public bool? Edited { get; set; }

    // Optional
    public string? LentTo { get; set; }

    // Optional, max 25 chars
    [StringLength(25)]
    public string? Notes { get; set; }
}