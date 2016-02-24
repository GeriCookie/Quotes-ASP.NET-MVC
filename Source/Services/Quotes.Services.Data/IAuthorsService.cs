using Quotes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotes.Services.Data
{
    public interface IAuthorsService
    {
        Author GetById(int id);
    }
}
