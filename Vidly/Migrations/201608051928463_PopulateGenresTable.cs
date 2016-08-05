namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres VALUES(1, 'Comedy')");
            Sql("INSERT INTO dbo.Genres VALUES(2, 'Romance')");
            Sql("INSERT INTO dbo.Genres VALUES(3, 'Action')");
            Sql("INSERT INTO dbo.Genres VALUES(4, 'Family')");
        }
        
        public override void Down()
        {
        }
    }
}
