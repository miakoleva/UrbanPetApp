namespace UrbanPetApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShoppingCarts", "User_Id", "dbo.Users");
            DropIndex("dbo.ShoppingCarts", new[] { "User_Id" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.ShoppingCarts", "User_Id", c => c.Int());
            AlterColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "Id");
            CreateIndex("dbo.ShoppingCarts", "User_Id");
            AddForeignKey("dbo.ShoppingCarts", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingCarts", "User_Id", "dbo.Users");
            DropIndex("dbo.ShoppingCarts", new[] { "User_Id" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ShoppingCarts", "User_Id", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Users", "Id");
            CreateIndex("dbo.ShoppingCarts", "User_Id");
            AddForeignKey("dbo.ShoppingCarts", "User_Id", "dbo.Users", "Id");
        }
    }
}
