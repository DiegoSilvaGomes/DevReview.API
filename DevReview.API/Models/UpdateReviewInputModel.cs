using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReview.API.Models
{
    public record UpdateReviewInputModel(string Title, string Description)
    {
    }
}
