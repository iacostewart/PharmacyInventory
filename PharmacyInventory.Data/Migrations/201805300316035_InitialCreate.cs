namespace PharmacyInventory.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drug",
                c => new
                    {
                        DrugId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        NDC = c.String(nullable: false, maxLength: 13),
                        LotNumber = c.String(nullable: false),
                        ExpirationDate = c.String(nullable: false, maxLength: 10),
                        Manufacturer = c.String(nullable: false, maxLength: 30),
                        Vendor = c.String(nullable: false, maxLength: 30),
                        ReOrderNumber = c.String(nullable: false, maxLength: 15),
                        Each = c.Boolean(),
                        Case = c.Boolean(),
                        LastPurchasePrice = c.Int(nullable: false),
                        LastPurchaseDate = c.String(),
                        LastPurchaseQuanity = c.String(maxLength: 10),
                        CustomInventoryNumber = c.String(maxLength: 10),
                        CII = c.Boolean(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                        CreatedBy = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.DrugId);
            
            CreateTable(
                "dbo.Equipment",
                c => new
                    {
                        EquipmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Manufacture = c.String(nullable: false),
                        SerialNumber = c.String(nullable: false),
                        InStock = c.Boolean(nullable: false),
                        NeedsPm = c.Boolean(),
                        LostOrBroken = c.Boolean(),
                        PurchaseDate = c.String(nullable: false),
                        LastCalibration = c.String(),
                    })
                .PrimaryKey(t => t.EquipmentId);
            
            CreateTable(
                "dbo.Inventory",
                c => new
                    {
                        InventoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Drug = c.Boolean(nullable: false),
                        Supply = c.Boolean(nullable: false),
                        RoomTemp = c.Boolean(nullable: false),
                        Refigerator = c.Boolean(nullable: false),
                        Vendor = c.String(nullable: false),
                        Quanity = c.Int(nullable: false),
                        EachesCases = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.InventoryId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RoleId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Supply",
                c => new
                    {
                        SupplyNumber = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LotNumber = c.String(),
                        ExpirationDate = c.String(),
                        Vendor = c.String(nullable: false),
                        ReOrderNumber = c.String(nullable: false),
                        PriceEach = c.Int(nullable: false),
                        PriceCase = c.Int(nullable: false),
                        LastOrderDate = c.String(),
                        ParLevelMin = c.String(nullable: false),
                        ParLevelMax = c.String(nullable: false),
                        StorageLocation = c.String(nullable: false),
                        CustomInventoryNumber = c.String(nullable: false),
                        LastDispensed = c.String(),
                    })
                .PrimaryKey(t => t.SupplyNumber);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Vendor",
                c => new
                    {
                        VendorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ActNumber = c.String(nullable: false),
                        SalesRep = c.String(),
                        SalesRepPhoneNumber = c.String(),
                        VendorPhoneNumber = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        DeliveryType = c.String(nullable: false),
                        EstimatedLeadTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VendorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropTable("dbo.Vendor");
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.Supply");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.Inventory");
            DropTable("dbo.Equipment");
            DropTable("dbo.Drug");
        }
    }
}
