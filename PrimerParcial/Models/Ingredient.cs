using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class Ingredient
    {
        // Clave Primaria (PK)
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty; 

        [Required]
        [StringLength(50)]
        public string Quantity { get; set; } = string.Empty; 

        [Display(Name = "Recipe")]
        public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
