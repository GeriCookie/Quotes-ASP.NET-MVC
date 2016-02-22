using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quotes.Data.Models;
using Quotes.Web.Infrastructure.Mapping;

namespace Quotes.Web.ViewModels.Users
{
    public class UserViewModel : IMapFrom<ApplicationUser>
    {
        public string Username { get; set; }
    }
}