namespace ef.Migrations
{
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<ef.Data.NerdDinnerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ef.Data.NerdDinnerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
