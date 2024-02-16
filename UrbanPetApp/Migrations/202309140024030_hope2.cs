namespace UrbanPetApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hope2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoppingCarts", "Total", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShoppingCarts", "Total");
        }
    }
}
