using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quotes.Data.Models;

namespace Quotes.Services.Data
{
    public interface IUpdatesService
    {
        Update GetById(int id);
        IQueryable<Update> All();
    }
}
