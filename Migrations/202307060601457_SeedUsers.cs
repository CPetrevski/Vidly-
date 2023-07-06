namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2f3dce9c-4333-43ea-b054-0a0a6f8a5c9b', N'admin@vidly.com', 0, N'ANBaeTAf7urjq4vY+ZFcxpbLtNVd/FhvAXUbNDI0HZO5BhOT2cq9Kp8X5/cHSIl9mw==', N'082941df-012e-44bf-b7d4-88bc5c8ccf29', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5968f29a-fa67-415a-b8be-ff98b7dbcae4', N'guest@vidly.com', 0, N'AJ3TSJy+VUzlOitxV6UHgZbkaIpCaCVitbe7WCrpIuspV4g6Of0I3lYTKONUSg6g0Q==', N'ff19d61b-3d53-4802-a41f-a12484e66c9a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'dcd0f2eb-bbed-49f2-87c9-27a6ef7a8ace', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2f3dce9c-4333-43ea-b054-0a0a6f8a5c9b', N'dcd0f2eb-bbed-49f2-87c9-27a6ef7a8ace')

");
        }
        
        public override void Down()
        {
        }
    }
}
