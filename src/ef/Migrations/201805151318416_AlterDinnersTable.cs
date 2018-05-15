namespace ef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterDinnersTable : DbMigration
    {
        public override void Up()
        {
			AlterColumn("Dinners", "Address", c => c.String(maxLength: 256));
			AlterColumn("Dinners", "Country", c => c.String(fixedLength: true, maxLength:2, nullable: false));
        }
        
        public override void Down()
        {
	        AlterColumn("Dinners", "Address", c => c.String(maxLength: 50));
	        AlterColumn("Dinners", "Country", c => c.String(fixedLength: false, maxLength:256, nullable: true));
        }
    }
}
