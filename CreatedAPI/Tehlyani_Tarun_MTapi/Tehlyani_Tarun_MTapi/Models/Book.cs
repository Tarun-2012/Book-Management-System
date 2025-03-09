using System.ComponentModel.DataAnnotations;

namespace Tehlyani_Tarun_MTapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public int PublishedYear { get; set; }
    }
}
