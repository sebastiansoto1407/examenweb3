using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class Recipe
    {
        // habia 4 errores y creando el archivo Models/Recipe.cs se corrigieron creando lo necesario a este archivo, ya entra a la pagina
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Description { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
