using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.Class.Composition
{
    class Composition
    {
        static void Main()
        {
            var installer = new Installer(new Logger());
            var logger = new Logger();
            var dbMigrator = new DbMigrator(logger);
            installer.install();
            dbMigrator.Migrate();
        }
    }
}
