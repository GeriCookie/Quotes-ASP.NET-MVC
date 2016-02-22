using Quotes.Data.Models;
using Quotes.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotes.Web.ViewModels.Quotes
{
    public class QuoteDetailsViewModel : IMapFrom<Quote>
    {
        public string Text { get; set; }

        public AuthorViewModel Author { get; set; }
    }
}
