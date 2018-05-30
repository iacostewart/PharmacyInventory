namespace PharmacyInventory.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Center",
                c => new
                    {
                        CenterId = c.Int(nullable: false, identity: true),
                        CenterName = c.String(nullable: false),
                        CenterAddress = c.String(nullable: false),
                        CenterManager = c.String(nullable: false),
                        RegionNumber = c.String(nullable: false),
                        CenterNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CenterId);
            
            CreateTable(
                "dbo.RegionalManager",
                c => new
                    {
                        managerId = c.Int(nullable: false, identity: true),
                        RegionalNumber = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        OutSideEmail = c.String(nullable: false),
                        CellPhoneContractNumber = c.String(nullable: false),
                        TravelExpenses = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.managerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegionalManager");
            DropTable("dbo.Center");
        }
    }
}
