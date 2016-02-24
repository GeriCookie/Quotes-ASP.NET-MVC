using Quotes.Data.Models;
using Quotes.Web.Infrastructure.Mapping;
using Quotes.Web.ViewModels.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quotes.Web.ViewModels.Authors
{
    public class AuthorDetailViewModel : IMapFrom<Author>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Url
        {
            get
            {
                return string.Format("/Authors/Details/{0}", this.Id);
            }
        }

        public IEnumerable<QuoteViewModel> Quotes { get; set; }

    }
}