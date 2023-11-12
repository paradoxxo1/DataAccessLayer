﻿using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public bool? CategoryStatus { get; set; }
        virtual public List<Product>? Prodcuts { get; set; }
    }
}
