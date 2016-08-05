namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateValueBirthdayCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Customers SET Birthday = '1984-02-21' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
