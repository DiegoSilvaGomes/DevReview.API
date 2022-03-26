using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevReview.API.Entities;

namespace DevReview.API.Persistence.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DevReviewContext context;

        public ReviewRepository(DevReviewContext context)
        {
            this.context = context;
        }

        public void Add(Review review)
        {
            context.Reviews.Add(review);
            context.SaveChanges();
        }

        public void Del(Review review)
        {
            context.Reviews.Remove(review);
            context.SaveChanges();
        }

        public IEnumerable<Review> GetAll(int id)
        {
            return context.Reviews.Where(r => r.ProductId == id);
        }

        public Review GetById(int reviewId)
        {
            return context.Reviews.SingleOrDefault(r => r.Id == reviewId);
        }

        public void Update(Review review)
        {
            context.Reviews.Update(review);
            context.SaveChanges();
        }
    }
}
