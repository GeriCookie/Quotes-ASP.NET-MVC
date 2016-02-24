using Quotes.Data.Models;
using Quotes.Services.Data;
using Quotes.Web.Infrastructure.Mapping;
using Quotes.Web.ViewModels.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quotes.Web.Controllers
{

    public class QuotesController :BaseController
    {
        private IQuotesService quotes;

        public QuotesController(IQuotesService quotes)
        {
            this.quotes = quotes;
        }

        // GET: Quotes
        public ActionResult Index()
        {
            var quotes = this.quotes.All().To<QuoteViewModel>();
            return View(quotes);
        }

        [Authorize]
        public ActionResult Add()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Add(QuoteInputModel quote)
        {
            if (!ModelState.IsValid)
            {
                return View(quote);
            }
            var newQuote = new Quote()
            {
                Text = quote.Text,
                Author = new Author()
                {
                    Name = quote.Author.Name
                }
            };

            var result = this.quotes.Add(newQuote);

            return RedirectToAction("Details", new { id = result});
        }

        public ActionResult Details(int id)
        {
            var quote = this.quotes.GetById(id);
            var vm = this.Mapper.Map<QuoteDetailsViewModel>(quote);
            return View(vm);
        }
    }
}