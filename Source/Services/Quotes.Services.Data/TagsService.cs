using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quotes.Data.Models;
using Quotes.Data.Common;

namespace Quotes.Services.Data
{
    public class TagsService : ITagsService
    {
        private IDbRepository<Tag> tags;

        public TagsService(IDbRepository<Tag> tags)
        {
            this.tags = tags;
        }

        public Tag GetById(int id)
        {
            return this.tags.GetById(id);
        }
    }
}
