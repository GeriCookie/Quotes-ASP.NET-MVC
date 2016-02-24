 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotes.MongoImporter
{
    public class Startup
    {
        public static void Main()
        {
            var importer = new MongoImporter();
            importer.Import();
            Console.ReadKey();
        }
    }
}
