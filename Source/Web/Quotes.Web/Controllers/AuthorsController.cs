using Quotes.Services.Data;
using Quotes.Web.ViewModels.Authors;
using Quotes.Web.ViewModels.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quotes.Web.Controllers
{
    public class AuthorsController : BaseController
    {
        private IAuthorsService authors;

        public AuthorsController(IAuthorsService authors)
        {
            this.authors = authors;
        }
        public ActionResult Details(int id)
        {
            var author = this.authors.GetById(id);
            var vm = this.Mapper.Map<AuthorDetailViewModel>(author);
            return View(vm);
        }
    }
}