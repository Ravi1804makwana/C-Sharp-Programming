using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator=new DBMigrator(new Logger());

            var logger = new Logger();
            var instller = new Installer(logger);

            dbMigrator.Migrate();
            instller.Install();
            System.Console.ReadKey();
        }
    }
}
