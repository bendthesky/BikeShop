namespace BikeShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BikeShopMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bikes", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bikes", "Price", c => c.String());
        }
    }
}
