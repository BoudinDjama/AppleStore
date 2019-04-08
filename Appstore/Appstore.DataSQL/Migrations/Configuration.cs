namespace Appstore.DataSqlite.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity.Migrations;
    using System.Data.SQLite.EF6.Migrations;
    using System.Linq;



    internal sealed class AppstoreConfiguration : DbMigrationsConfiguration<Appstore.DataSqlite.AppstoreContext>
    {
        public AppstoreConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());

        }
        protected override void Seed(Appstore.DataSqlite.AppstoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

       
        }
    }

}
