using FluentMigrator;

namespace Db.fluentmigrator.Migrations
{
	[Migration(152638826976297)]
	public class M152638826976297_AlterDinnersTable : Migration
	{
		public override void Up()
		{
			// this is a data-breaking migration. Backups are your friends
			Alter.Table("Dinners")
				.AlterColumn("Address").AsString(256)
				.AlterColumn("Country").AsFixedLengthString(2).NotNullable();
		}

		public override void Down()
		{
			Alter.Table("Dinners")
				.AlterColumn("Address").AsString(50)
				.AlterColumn("Country").AsString(256).Nullable();

			// restore the data from backup
		}
	}
}