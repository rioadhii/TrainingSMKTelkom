using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookInventory.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int GenreId { get; set; }

        [MaxLength(250)]
        [Required]
        public string Title { get; set; }

        [MaxLength(250)]
        [Required]
        public string Author { get; set; }

        [Range(1900, 2019, ErrorMessage = "Year must between 1900-2019")]
        public int PublishYear { get; set; }

        [MaxLength(50)]
        [Required]
        public string ISBN { get; set; }

        [ForeignKey("GenreId")]
        public virtual MsGenre MsGenre { get; set; }
    }
}