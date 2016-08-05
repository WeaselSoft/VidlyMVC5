namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNameTableMemebershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.MembershipTypes SET Name = 'On Demand' WHERE Id = 1");
            Sql("UPDATE dbo.MembershipTypes SET Name = '1 Month' WHERE Id = 2");
            Sql("UPDATE dbo.MembershipTypes SET Name = '3 Months' WHERE Id = 3");
            Sql("UPDATE dbo.MembershipTypes SET Name = '1 Year' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
