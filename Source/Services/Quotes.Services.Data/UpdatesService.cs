using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quotes.Data.Common;
using Quotes.Data.Models;

namespace Quotes.Services.Data
{
    public class UpdatesService : IUpdatesService
    {
        private IDbRepository<Update> updates;

        public UpdatesService(IDbRepository<Update> updates)
        {
            this.updates = updates;
        }

        public Update GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Update> All()
        {
            return updates.All();
        }
    }
}
