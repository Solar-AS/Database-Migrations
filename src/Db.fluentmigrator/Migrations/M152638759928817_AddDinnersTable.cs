using FluentMigrator;

namespace Db.fluentmigrator.Migrations
{
	[Migration(152638759928817)]
	public class M152638759928817_AddDinnersTable : Migration
	{
		public override void Up()
		{
			Create.Table("Dinners")
				.WithColumn("Id").AsInt32().PrimaryKey()
				.WithColumn("Title").AsString(50).NotNullable()
				.WithColumn("EventDate").AsDateTimeOffset().NotNullable()
				.WithColumn("Description").AsString(256).NotNullable()
				.WithColumn("HostedBy").AsString(20).Nullable()
				.WithColumn("ContactPhone").AsString(20).NotNullable()
				.WithColumn("Address").AsString(50).NotNullable()
				.WithColumn("Country").AsString(256).Nullable();
		}

		public override void Down()
		{
			Delete.Table("Dinners");
		}
	}
}