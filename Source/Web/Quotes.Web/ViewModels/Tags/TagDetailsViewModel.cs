using Quotes.Data.Models;
using Quotes.Web.Infrastructure.Mapping;
using Quotes.Web.ViewModels.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotes.Web.ViewModels.Tags
{
    public class TagDetailsViewModel : IMapFrom<Tag>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url
        {
            get
            {
                return string.Format("/Tags/Details/{0}", this.Id);
            }
        }
        public IEnumerable<QuoteViewModel> Quotes { get; set; }
    }
}
