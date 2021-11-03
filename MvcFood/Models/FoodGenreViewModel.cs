using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcFood.Models
{
    public class FoodGenreViewModel
    {
        public List<Food>? Foods { get; set; }
        public SelectList? Genres { get; set; }
        public string? FoodGenre { get; set; }
        public string? SearchString { get; set; }

    }
}
