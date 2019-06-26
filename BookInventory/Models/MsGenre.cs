using System.ComponentModel.DataAnnotations;

namespace BookInventory.Models
{
    public class MsGenre
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; }
    }
}