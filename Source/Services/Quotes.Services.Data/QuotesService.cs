using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quotes.Data.Models;
using Quotes.Data.Common;

namespace Quotes.Services.Data
{
    public class QuotesService : IQuotesService
    {
        private IDbRepository<Quote> quotes;

        public QuotesService(IDbRepository<Quote> quotes)
        {
            this.quotes = quotes;
        }

        public int Add(Quote quote)
        {
            this.quotes.Add(quote);
            this.quotes.Save();
            var result = this.quotes.GetById(quote.Id);

            if (result != null)
            {
                return result.Id;
            }
            return 0;
        }

        public Quote GetById(int id)
        {
            return this.quotes.GetById(id);
        }
    }
}
