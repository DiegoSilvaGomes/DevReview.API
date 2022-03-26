using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReview.API.Models
{
    public record AddProductInputModel(string ProductName, string Description, string Brand, string Producer, string ProductType, string User)
    {

    }
}
