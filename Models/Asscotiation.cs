using System.ComponentModel.DataAnnotations;

namespace ProductsandCats.Models
{
    public class Asscotiation
    {
        [Key]
        public int AssociationId { get; set; }
        
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public Product ProductAssoc { get; set; }
        public Category CategoryAssoc { get; set; } 
    }
}