namespace Quotes.Web.ViewModels.Quotes
{
    using Data.Models;
    using Web.Infrastructure.Mapping;

    public class QuoteDetailsViewModel : IMapFrom<Quote>
    {
        public string Text { get; set; }

        public AuthorViewModel Author { get; set; }
    }
}
