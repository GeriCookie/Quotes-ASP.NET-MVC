using Quotes.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotes.Data.Models
{
    public class Quote : BaseModel<int>
    {
        private ICollection<Tag> tags;
        private ICollection<Favorite> favorite;

        public Quote()
        {
            this.tags = new HashSet<Tag>();
        }

        public string Text { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public virtual ICollection<Tag> Tags
        {
            get
            {
                return this.tags;
            }

            set
            {
                this.tags = value;
            }
        }

        public virtual ICollection<Favorite> Favorites
        {
            get
            {
                return this.favorite;
            }
        }
    }
}
