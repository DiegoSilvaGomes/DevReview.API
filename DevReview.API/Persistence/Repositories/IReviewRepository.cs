using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevReview.API.Entities;

namespace DevReview.API.Persistence.Repositories
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetAll(int id);
        Review GetById(int reviewId);
        void Add(Review review);
        void Update(Review review);
        void Del(Review review);
    }
}
