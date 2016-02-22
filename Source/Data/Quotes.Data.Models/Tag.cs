using Quotes.Data.Common.Models;
using System.Collections.Generic;

namespace Quotes.Data.Models
{
    public class Tag : BaseModel<int>
    {
        private ICollection<Quote> quotes;

        public Tag()
        {
            this.quotes = new HashSet<Quote>();
        }

        public string Name { get; set; }

        public virtual ICollection<Quote> Quotes
        {
            get
            {
                return this.quotes;
            }

            set
            {
                this.quotes = value;
            }
        }
    }
}