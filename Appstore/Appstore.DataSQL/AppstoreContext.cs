using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appstore.DataSqlite
{
    class AppstoreContext : DbContext
    {
        Database.SetInitializer(
            new MigrateDatabaseToLatestVersion
            <AppstoreContext, AppstoreConfiguration>(true));
    }
}
