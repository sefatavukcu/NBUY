﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.API.Model;
using ShoppingApi.Business.Abstract;
using ShoppingApi.Core;
using ShoppingApi.Entity.Concrete;

namespace ShoppingApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        //Projenizde Swagger var ise tüm actin metotlarınızın Http Request türü yazılmalıdır. HttpGet, HttpPost vb.
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetAllAsync();
            List<ProductDto> productDtos = new List<ProductDto>();
            foreach (var product in products)
            {
                productDtos.Add(new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    ImageUrl = product.ImageUrl,
                    Url = product.ImageUrl,
                    Price = product.Price
                });
            }
            return Ok(productDtos);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product==null)
            {
                return NotFound();
            }
            ProductDto productDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Url = product.ImageUrl,
                Price = product.Price
            };

            return Ok(productDto);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductDto productDto)
        {
            if (productDto==null)
            {
                return NotFound();
            }
            Product product = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Description = productDto.Description,
                ImageUrl = productDto.ImageUrl,
                Url = Jobs.InitUrl(productDto.Name)
            };
            await _productService.CreateAsync(product);
            //return Ok(product);
            productDto.Id= product.Id;
            productDto.Url= productDto.Url;
            return CreatedAtAction("GetProduct", new {id = product.Id}, productDto);
        }
    }
}
