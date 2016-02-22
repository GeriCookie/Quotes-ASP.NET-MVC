using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quotes.Data.Models;
using Quotes.Web.Infrastructure.Mapping;
using Quotes.Web.ViewModels.Quotes;
using Quotes.Web.ViewModels.Users;

namespace Quotes.Web.ViewModels.Updates
{
    using System.Collections;
    using System.Collections.Generic;

    public class UpdateViewModel : IMapFrom<Update>
    {
        public string Text { get; set; }

        public UserViewModel User { get; set; }
        
        public QuoteViewModel Quote { get; set; }
    }
}