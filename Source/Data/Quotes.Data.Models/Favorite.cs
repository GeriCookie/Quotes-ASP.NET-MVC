using Quotes.Data.Common.Models;

namespace Quotes.Data.Models
{
    public class Favorite : BaseModel<int>
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int QuoteId { get; set; }

        public virtual Quote Quote { get; set; }
    }
}