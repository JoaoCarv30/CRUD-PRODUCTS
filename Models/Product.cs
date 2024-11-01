using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsCrud.Models
{
    public class Product
    {
        
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        public string Image { get; set; } = String.Empty;

        
    }
}