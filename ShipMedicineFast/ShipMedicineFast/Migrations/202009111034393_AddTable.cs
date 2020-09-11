namespace ShipMedicineFast.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BannerName = c.String(nullable: false, maxLength: 100),
                        Image = c.String(maxLength: 500),
                        Width = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Location = c.Int(nullable: false),
                        Url = c.String(maxLength: 500),
                        DisplayOrder = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ConfigSites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Facebook = c.String(maxLength: 500),
                        Youtube = c.String(maxLength: 500),
                        Instagram = c.String(maxLength: 500),
                        Twitter = c.String(maxLength: 500),
                        FacebookPage = c.String(maxLength: 4000),
                        TitleHeader = c.String(maxLength: 200),
                        Address = c.String(maxLength: 500),
                        PhoneNumber = c.String(maxLength: 15),
                        Email = c.String(maxLength: 100),
                        Logo = c.String(maxLength: 500),
                        PrivacyPolicy = c.String(storeType: "ntext"),
                        About = c.String(storeType: "ntext"),
                        Services = c.String(storeType: "ntext"),
                        Payment = c.String(storeType: "ntext"),
                        Contact = c.String(storeType: "ntext"),
                        Helper = c.String(storeType: "ntext"),
                        Transport = c.String(storeType: "ntext"),
                        Conditions = c.String(storeType: "ntext"),
                        RefundPolicy = c.String(storeType: "ntext"),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FeedBacks",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        FullNname = c.String(),
                        Content = c.String(nullable: false, storeType: "ntext"),
                        Description = c.String(nullable: false, maxLength: 500),
                        DisplayOrder = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        FlagHome = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Account = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 15),
                        LastName = c.String(nullable: false, maxLength: 15),
                        Email = c.String(maxLength: 50),
                        Address = c.String(maxLength: 200),
                        Phone = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        Role = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PostCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                        Url = c.String(maxLength: 500),
                        DisplayOrder = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        ShowOnHome = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Subject = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 500),
                        Content = c.String(nullable: false),
                        Image = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        DisPlayOrder = c.Int(nullable: false),
                        View = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        FlagHome = c.Boolean(nullable: false),
                        PostCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PostCategories", t => t.PostCategoryID, cascadeDelete: true)
                .Index(t => t.PostCategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "PostCategoryID", "dbo.PostCategories");
            DropIndex("dbo.Posts", new[] { "PostCategoryID" });
            DropTable("dbo.Posts");
            DropTable("dbo.PostCategories");
            DropTable("dbo.Members");
            DropTable("dbo.FeedBacks");
            DropTable("dbo.ConfigSites");
            DropTable("dbo.Banners");
        }
    }
}
