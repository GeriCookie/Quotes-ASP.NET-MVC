using System;
using System.Linq;

using SQL = Quotes.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using Quotes.Data;
using Quotes.Data.Common;
using Quotes.MongoImporter.Models;
using Quotes.Services.Data;

namespace Quotes.MongoImporter
{
    using MongoDB.Driver;

    public class MongoImporter
    {
        const string DefaultConnectionString = "mongodb://nativescript:123456@ds027719.mongolab.com:27719/quotesapi";

        public MongoImporter()
            : this(DefaultConnectionString)
        {

        }

        public MongoImporter(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        public async void Import()
        {
            IEnumerable<Quote> quotes = await this.GetQuotes();
            var context = new ApplicationDbContext();
            IDbRepository<SQL.Quote> repo = new DbRepository<SQL.Quote>(context);
            var quotesService = new QuotesService(repo);

            foreach (var quote in quotes)
            {
                if (repo.All().Any(q => q.Text.ToLower() == quote.Text.ToLower()))
                {
                    continue;
                }
                quotesService.Add(new SQL.Quote()
                {
                    Text = quote.Text,
                    Author = this.LoadOrCreateAuthor(context, quote.Author, quote.AuthorImageUrl),
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false,
                    Tags = quote.Tags.Select(tag => new SQL.Tag
                    {
                        Name = tag
                    }
                    ).ToList()

                });
                Console.Write(".");
            }
            Console.WriteLine("Done!");
        }

        private SQL.Author LoadOrCreateAuthor(ApplicationDbContext context, string author, string authorImageUrl)
        {
            IDbRepository<SQL.Author> repo = new DbRepository<SQL.Author>(context);
            var dbAuthor = repo.All()
                .FirstOrDefault(a => a.Name.ToLower() == author.ToLower()) ?? new SQL.Author
                {
                    Name = author,
                    ImageUrl = authorImageUrl,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false
                };

            return dbAuthor;
        }

        private async Task<IEnumerable<Quote>> GetQuotes()
        {
            var client = new MongoClient(this.ConnectionString);
            var db = client.GetDatabase("quotesapi");
            var collection = db.GetCollection<Quote>("quotes");

            return (await collection.FindAsync(new BsonDocument())).ToList();
        }
    }
}
