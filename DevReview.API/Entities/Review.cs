using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReview.API.Entities
{
    public class Review
    {
        public Review(string title, string description, string user, int productId)
        {
            Title = title;
            Description = description;
            User = user;
            ProductId = productId;

            CreatedAt = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string User { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int ProductId { get; private set; }

        public void Update(string title, string description)
        {
            Title = title;
            Description = description;
        }

    }
}
