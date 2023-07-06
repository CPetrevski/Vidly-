namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], 
[AccessFailedCount], [UserName]) VALUES (N'4286a717-cc93-45cb-87eb-7845edcb8307', N'admin@vidly.com', 0, N'AC/9ePDLhAvIawhFUuyEyH3QqweAEfTTkXqqS/3z/ygGGdvn8BXFM9iYgWZX9TFXNw==', N'5bd413d2-8d33-4cc3-b2ba-3dc8e979c044', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4edbf939-46d4-455e-b7f5-2fc47f0545e9', N'guest@vidly.com', 0, N'APx3Y4RRMi7G6S3tEO91hdOz91MWX0ZL9gyBLa6yT+s+LWJVtxvaZwa4NPeNTeOruw==', N'c3e411de-a7e3-4e5f-8725-edc4803aa532', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'22361062-563f-4aeb-9596-427171ee0b18', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4286a717-cc93-45cb-87eb-7845edcb8307', N'22361062-563f-4aeb-9596-427171ee0b18')
");
        }
        
        public override void Down()
        {
        }
    }
}
