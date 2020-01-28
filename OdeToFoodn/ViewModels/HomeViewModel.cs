using System.Collections.Generic;
using OdeToFoodn.Models;

namespace OdeToFoodn.ViewModels
{
    public class HomeViewModel
    {
        
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}