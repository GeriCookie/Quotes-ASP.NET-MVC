using Quotes.Data.Common.Models;

namespace Quotes.Data.Models
{
    public class Comment: BaseModel<int>
    {
        public string Text { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int UpdateId { get; set; }

        public virtual Update Update { get; set; }
    }
}