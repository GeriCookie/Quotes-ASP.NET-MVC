
namespace Quotes.Web.ViewModels.Quotes
{
    using Data.Models;
    using Web.Infrastructure.Mapping;

    public class QuoteViewModel : IMapFrom<Quote>
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}