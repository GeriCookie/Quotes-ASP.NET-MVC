using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quotes.Data.Models;
using Quotes.Data.Common;

namespace Quotes.Services.Data
{
    public class AuthorsService : IAuthorsService
    {
        private IDbRepository<Author> authors;

        public AuthorsService(IDbRepository<Author> authors)
        {
            this.authors = authors;
        }

        public Author GetById(int id)
        {
            return this.authors.GetById(id);
        }
    }
}
