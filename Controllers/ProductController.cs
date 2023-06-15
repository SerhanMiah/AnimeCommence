using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeShop.Data;
using AnimeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeCommence.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ContextAnime _context;

        public ProductController(ContextAnime context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _context.Products
                .Include(p => p.Images)
                .ToListAsync();

            return products;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _context.Products
                .Include(p => p.Images)
                .FirstOrDefaultAsync(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpGet("genre/{genre}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByGenre(string genre)
        {
            if (Enum.TryParse(genre, out Genre genreValue))
            {
                return await _context.Products
                    .Where(p => p.Genre == genreValue)
                    .Include(p => p.Images)
                    .ToListAsync();
            }

            return BadRequest("Invalid genre provided");
        }

        [HttpGet("category/{category}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByCategory(string category)
        {
            if (Enum.TryParse(category, out Category categoryValue))
            {
                return await _context.Products
                    .Where(p => p.Category == categoryValue)
                    .Include(p => p.Images)
                    .ToListAsync();
            }

            return BadRequest("Invalid category provided");
        }
    }
}
