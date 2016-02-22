using Quotes.Data.Models;
using Quotes.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quotes.Web.ViewModels.Quotes
{
    public class QuoteInputModel : IMapTo<Quote>
    {
        [Required]
        public string Text { get; set; }

        public AuthorInputModel Author { get; set; }
    }
}