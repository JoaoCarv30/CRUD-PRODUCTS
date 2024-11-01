using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsCrud.Data;
using ProductsCrud.Models;

namespace ProductsCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        private ProductContext _context;  // Variável para acessar o banco de dados
        public ProductController(ProductContext context) // Construtor que recebe o contexto do banco de dados
        {
            _context = context;
        }


        // Lista estática para manter os produtos em memória temporariamente

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _context.Products.Add(product); // Adiciona o produto ao contexto
            _context.SaveChanges(); // Salva as alterações no banco de dados
            return Ok(product); // Retorna o produto criado
        } 

        // Exemplo de método para listar todos os produtos
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Products.ToList()); // Retorna a lista de produtos
        }

        // Exemplo de método para buscar um produto pelo ID
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _context.Products.Find(id); // Busca o produto pelo ID
            if (product == null)
            {
                return NotFound(); // Retorna 404 Not Found se o produto não for encontrado
            }
            return Ok(product); // Retorna o produto encontrado
        }

        // Exemplo de método para atualizar um produto
        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            var existingProduct = _context.Products.Find(id); // Busca o produto pelo ID
            if (existingProduct == null)
            {
                return NotFound(); // Retorna 404 Not Found se o produto não for encontrado
            }
            existingProduct.Name = product.Name; // Atualiza o nome do produto
            existingProduct.Description = product.Description; // Atualiza a descrição do produto
            existingProduct.Price = product.Price; // Atualiza o preço do produto
            existingProduct.Quantity = product.Quantity; // Atualiza a quantidade do produto
            existingProduct.Image = product.Image; // Atualiza a imagem do produto
            _context.SaveChanges(); // Salva as alterações no banco de dados
            return Ok(existingProduct); // Retorna o produto atualizado
        }

        // Exemplo de método para excluir um produto
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id); // Busca o produto pelo ID
            if (product == null)
            {
                return NotFound(); // Retorna 404 Not Found se o produto não for encontrado
            }
            _context.Products.Remove(product); // Remove o produto do contexto
            _context.SaveChanges(); // Salva as alterações no banco de dados
            return Ok(); // Retorna uma resposta de sucesso
        }

    }
}
