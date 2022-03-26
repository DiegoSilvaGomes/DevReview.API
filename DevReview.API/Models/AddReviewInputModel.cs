using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReview.API.Models
{
    public record AddReviewInputModel(string Title, string Description, string User)
    {

    }
}
