using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DevReview.API.Entities;
using DevReview.API.Models;
using DevReview.API.Persistence;
using DevReview.API.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IProductRepository repository;

        public ProductsController(IMapper mapper, IProductRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var product = repository.GetAll();

            return Ok(product);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = repository.GetById(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Request Body Example:
        /// {
        /// "productName": "PlayStation 5",
        /// "description": "Jogar não Tem Limites. Desfrute do carregamento extremamente rápido com o SSD de altíssima velocidade, uma imersão mais profunda com suporte a feedback tátil, gatilhos adaptáveis e áudio 3D, além de uma geração inédita de jogos incríveis para Console Playstation 5 - PS5.",
        /// "brand": "Sony",
        /// "producer": "Sony",
        /// "productType": "Video Game",
        /// "user": "Bruce"
        /// }
        /// </remarks>
        /// <param name="model">Products data</param>
        /// <returns>Created object</returns>
        /// <response code="201">Success</response>
        /// <response code="400">Invalid data</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(AddProductInputModel model)
        {
            var product = mapper.Map<Product>(model);

            repository.Add(product);

            return CreatedAtAction(nameof(GetById), new { id = product.Id}, model);
        }

    }
}
