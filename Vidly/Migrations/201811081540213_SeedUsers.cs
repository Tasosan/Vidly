namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'30b83c2f-8ce2-4494-9f1f-1383264b5862', N'guest@vidly.com', 0, N'AO41jcKuR+L6UvWKICrwuhNFdwV7nJGZ99tNGeXXdh/sn1h47etSQB2Z0ih2v78rTw==', N'e8915041-7863-4c13-ae48-df9a6925877a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'47d7a009-e560-46ce-bad6-ce674cead330', N'admin@vidly.com', 0, N'APj1jMsUKoGa5LvY04DoCDbrNjtS834zXcwAQhzJbeqvahMru1jVzI43POUUKUDcqQ==', N'f265577f-6e8d-4f72-96ec-3b86856a5f06', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2139d54a-ef0a-4ce0-bedd-3bd1568aa641', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'47d7a009-e560-46ce-bad6-ce674cead330', N'2139d54a-ef0a-4ce0-bedd-3bd1568aa641')
");
        }
        
        public override void Down()
        {
        }
    }
}
