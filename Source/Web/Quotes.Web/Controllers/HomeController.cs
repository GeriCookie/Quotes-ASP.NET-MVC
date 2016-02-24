using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Quotes.Services.Data;
using Quotes.Web.Infrastructure.Mapping;
using Quotes.Web.ViewModels.Updates;
using Quotes.Web.ViewModels.Users;

namespace Quotes.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IUpdatesService _service;

        public HomeController(IUpdatesService service)
        {
            this._service = service;
        }

        public ActionResult Index()
        {
            return this.View(this._service.All().To<UpdateViewModel>());
        }
    }
}
