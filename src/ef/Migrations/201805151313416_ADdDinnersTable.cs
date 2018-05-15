namespace ef.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddDinnersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dinners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        EventDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Description = c.String(nullable: false, maxLength: 256),
                        HostedBy = c.String(nullable: true, maxLength: 20),
                        ContactPhone = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 50),
                        Country = c.String(nullable: true, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dinners");
        }
    }
}
