using Quotes.Services.Data;
using Quotes.Web.ViewModels.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quotes.Web.Controllers
{
    public class TagsController : BaseController
    {
        private ITagsService tags;

        public TagsController(ITagsService tags)
        {
            this.tags = tags;
        }
        public ActionResult Details(int id)
        {
            var tag = this.tags.GetById(id);
            var vm = this.Mapper.Map<TagDetailsViewModel>(tag);
            return View(vm);
        }
    }
}