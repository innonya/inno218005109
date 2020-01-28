using System.ComponentModel.DataAnnotations;
using OdeToFoodn.Models;

namespace OdeToFoodn.ViewModels
{
    public class RestaurantEditViewModel
    {
        
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}