using System.ComponentModel.DataAnnotations;

namespace RecipeBook.ViewModels.Home
{
    public class CreateRecipeViewModel
    {
        [Required]
        [Display(Name = "Recipe name")]
        public string RecipeName { get; set; }
        
        [Required]
        [Display(Name = "Recipe text")]
        [DataType(DataType.MultilineText)]
        public string RecipeText { get; set; }
    }
}