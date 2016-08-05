namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Movies VALUES('Hangover', '2012-12-10', '2013-01-25', 4, 1)");
            Sql("INSERT INTO dbo.Movies VALUES('Die Hard', '2008-01-01', '2010-08-01', 5, 3)");
            Sql("INSERT INTO dbo.Movies VALUES('The Terminator', '2000-08-02', '2001-02-17', 2, 3)");
            Sql("INSERT INTO dbo.Movies VALUES('Toy Story', '2001-05-04', '2003-05-20', 4, 4)");
            Sql("INSERT INTO dbo.Movies VALUES('Titanic', '2006-06-06', '2006-08-20', 1, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
