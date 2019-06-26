using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookInventory.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public int GenreId { get; set; }

        [MaxLength(250)]
        [Required]
        public string Title { get; set; }

        [MaxLength(250)]
        [Required]
        public string Author { get; set; }

        [MaxLength(4)]
        [Required]
        public string PublishYear { get; set; }

        [MaxLength(50)]
        [Required]
        public string ISBN { get; set; }

        [ForeignKey("GenreId")]
        public virtual MsGenre MsGenre { get; set; }
    }
}