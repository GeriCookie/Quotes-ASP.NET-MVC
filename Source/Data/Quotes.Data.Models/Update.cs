using Quotes.Data.Common.Models;
using System.Collections;
using System.Collections.Generic;

namespace Quotes.Data.Models
{
    public class Update : BaseModel<int>
    {
        private ICollection<Comment> comments;

        public string Text { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int QuoteId { get; set; }

        public virtual Quote Quote { get; set; }

        public virtual ICollection<Comment> Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }


    }
}