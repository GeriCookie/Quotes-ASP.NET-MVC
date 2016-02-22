using Quotes.Data.Models;
using Quotes.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotes.Web.ViewModels.Quotes
{
    public class AuthorInputModel : IMapTo<Author>
    {
        [Required]
        [DisplayName("Author Name")]
        public string Name { get; set; }

        public string ImageUrl { get; set; }
    }
}
