using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReview.API.Entities
{
    public class Product
    {
        public Product(string productName, string description, string brand, string producer, string productType, string user)
        {
            ProductName = productName;
            Description = description;
            Brand = brand;
            Producer = producer;
            ProductType = productType;
            User = user;

            CreateAt = DateTime.Now;

            Reviews = new List<Review>();
        }
        public int Id { get; private set; }
        public string ProductName { get; private set; }
        public string Description { get; private set; }
        public string Brand { get; private set; }
        public string Producer { get; private set; }
        public string ProductType { get; private set; }
        public string User { get; private set; }
        public DateTime CreateAt { get; private set; }
        public List<Review> Reviews { get; private set; }

        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }
    }
}
