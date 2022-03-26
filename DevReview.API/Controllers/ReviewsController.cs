using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DevReview.API.Entities;
using DevReview.API.Models;
using DevReview.API.Persistence;
using DevReview.API.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DevReview.API.Controllers
{
    [Route("api/products/{id}/reviews")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IReviewRepository repository;

        public ReviewsController(IMapper mapper, IReviewRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll(int id)
        {
            var review = repository.GetAll(id);

            if (review == null)
                return NotFound();

            return Ok(review);
        }

        [HttpGet("{reviewId}")]
        public IActionResult GetById(int reviewId)
        {
            var review = repository.GetById(reviewId);

            if (review == null)
                return NotFound();

            return Ok(review);
        }

        [HttpPost]
        public IActionResult Post(int id, AddReviewInputModel model)
        {
            var review = new Review(model.Title, model.Description, model.User, id);

            repository.Add(review);

            return CreatedAtAction(nameof(GetById), new { id = id, reviewId = review.Id}, model);
        }
        
        [HttpPut("{reviewId}")]
        public IActionResult Put(int reviewId, UpdateReviewInputModel model)
        {
            var review = repository.GetById(reviewId);

            if (review == null)
                return NotFound();

            review.Update(model.Title, model.Description);

            repository.Update(review);

            return NoContent();
        }

        [HttpDelete("{reviewId}")]
        public IActionResult Delete(int reviewId)
        {
            var review = repository.GetById(reviewId);

            if (review == null)
                return NotFound();

            repository.Del(review);

            return NoContent();
        }
    }
}
