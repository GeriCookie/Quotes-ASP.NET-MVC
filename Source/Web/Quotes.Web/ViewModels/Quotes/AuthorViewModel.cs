using Quotes.Data.Models;
using Quotes.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotes.Web.ViewModels.Quotes
{
    public class AuthorViewModel : IMapFrom<Author>
    {
        public string Name { get; set; }

    }
}
