using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsCrud.Models;

namespace ProductsCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // Lista estática para manter os produtos em memória temporariamente
        private static List<Product> products = new List<Product>();

        [HttpPost]
        public IActionResult Create(Product product)
        {
            products.Add(product);
            return Ok(products);
        }

        // Exemplo de método para listar todos os produtos
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(products);
        }
    }
}
