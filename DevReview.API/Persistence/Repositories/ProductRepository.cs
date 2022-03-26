using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevReview.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevReview.API.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DevReviewContext context;

        public ProductRepository(DevReviewContext context)
        {
            this.context = context;
        }

        public void Add(Product product)
        {
            context.Products.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return context
                .Products
                .Include(p => p.Reviews)
                .SingleOrDefault(p => p.Id == id);
        }
    }
}
