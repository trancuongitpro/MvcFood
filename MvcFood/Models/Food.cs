﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MvcFood.Models
{
    public class Food
    {
        public int id { get; set; }
        public string? Title { get; set; }

        [Display(Name = "Release Date")]

        [DataType(DataType.Date)]

        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]

        public decimal Price { get; set; }
        public string Img { get; set; }

    }
}
