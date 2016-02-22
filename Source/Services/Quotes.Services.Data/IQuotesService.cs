using Quotes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotes.Services.Data
{
    public interface IQuotesService
    {
        Quote GetById(int id);
        int Add(Quote quote);
    }
}
