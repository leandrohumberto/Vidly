namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO dbo.Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO dbo.Genres (Name) VALUES ('Family')");
            Sql("INSERT INTO dbo.Genres (Name) VALUES ('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
