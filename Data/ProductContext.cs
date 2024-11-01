using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductsCrud.Models;

namespace ProductsCrud.Data
{
    public class ProductContext : DbContext //Estamos dizendo que nossa classe ProductContext herda de DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) //Construtor que recebe um objeto do tipo DbContextOptions<ProductContext> e passa para a classe base
        {
            
        }
        public DbSet<Product> Products { get; set; } //Propriedade do tipo DbSet<Product> que representa a tabela de produtos no banco de dados

        
    }
}









