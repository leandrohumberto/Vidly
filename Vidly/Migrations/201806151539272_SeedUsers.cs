namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        { 
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'17ec807a-6c49-4f94-b5f4-db291d1cc4f3', N'admin@vidly.com', 0, N'AGrMjC1AnE1JwIKuXFNrz9XTM/fAHXmIc60fEXofPtijQ24arT++EveLLtv+2z7EpA==', N'3e6985f3-b7f4-45d2-bce4-c7cc5361f347', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')");
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'24a04a30-0728-49c5-96e0-44231b3ff426', N'guest@vidly.com', 0, N'AOelwF71BW8l6yN+nHBgNYjEVsMpbK/MCB1dv4jpSEsNJQqy8CZ+iqjPl1YKld7vjg==', N'ea16ee9d-7af0-4059-9b0d-4e87047b00ae', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')");
            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd110bdb8-0018-4035-ab4f-e8ee66a78055', N'CanManageMovies')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'17ec807a-6c49-4f94-b5f4-db291d1cc4f3', N'd110bdb8-0018-4035-ab4f-e8ee66a78055')");
        }
        
        public override void Down()
        {
        }
    }
}
