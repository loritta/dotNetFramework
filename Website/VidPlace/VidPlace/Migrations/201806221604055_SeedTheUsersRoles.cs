namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedTheUsersRoles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], " +
                "[PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) " +
                "VALUES (N'df282e1e-5b2a-47da-8e71-e400f0283298', N'user@email.com', 0, " +
                "N'ANZh3z2DkBMDVmiGD4bcs1aidAUqytWPNnsM9jo3Bb5lXqcn+VAUVvJtY+UwEYapmg==', N'059de613-62f6-4864-a926-96e7f77eac71', " +
                "NULL, 0, 0, NULL, 1, 0, N'user@email.com')" +
                "INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], " +
                "[PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) " +
                "VALUES(N'e0b0f2b1-cd49-457d-8d5e-8c740de914f4', N'admin@email.com', 0, " +
                "N'ALOaZPG0fxNKW+LMOKgB1oi4Vwiex8lT0w+Ipk/vSptCNV3sZvqBw0zWd4fjN0419Q==', N'949a30f9-1768-491c-870f-8c3d603fbba0', " +
                "NULL, 0, 0, NULL, 1, 0, N'admin@email.com')");
            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'91b29d83-2724-4d8b-9c1b-a5f6e3d89480', N'CanManageMedia')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e0b0f2b1-cd49-457d-8d5e-8c740de914f4', " +
                "N'91b29d83-2724-4d8b-9c1b-a5f6e3d89480')");
        }
        
        public override void Down()
        {
        }
    }
}
