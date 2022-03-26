using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevReview.API.Entities;

namespace DevReview.API.Persistence.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
    }
}
