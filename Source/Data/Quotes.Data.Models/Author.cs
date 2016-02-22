using Quotes.Data.Common.Models;
using System.Collections.Generic;

namespace Quotes.Data.Models
{
    public class Author : BaseModel<int>
    {
        private ICollection<Quote> quotes;

        public Author()
        {
            this.quotes = new HashSet<Quote>();
        }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

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