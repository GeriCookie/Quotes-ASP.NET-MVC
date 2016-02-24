namespace Quotes.Web.ViewModels.Quotes
{
    using Data.Models;
    using System.Collections.Generic;
    using Web.Infrastructure.Mapping;

    public class QuoteDetailsViewModel : IMapFrom<Quote>
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public AuthorViewModel Author { get; set; }

        public IEnumerable<TagViewModel> Tags { get; set; }

        public string Url
        {
            get
            {
                return string.Format("/Quotes/Details/{0}", this.Id);
            }
        }
    }
}
