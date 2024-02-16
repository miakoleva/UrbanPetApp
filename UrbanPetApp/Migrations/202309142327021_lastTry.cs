namespace UrbanPetApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastTry : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "ShoppingCart_Id", "dbo.ShoppingCarts");
            DropForeignKey("dbo.ShoppingCarts", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Carts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "Product_Id", "dbo.Products");
            DropIndex("dbo.Carts", new[] { "Product_Id" });
            DropIndex("dbo.Products", new[] { "ShoppingCart_Id" });
            DropIndex("dbo.OrderDetails", new[] { "Product_Id" });
            DropIndex("dbo.ShoppingCarts", new[] { "User_Id" });
            RenameColumn(table: "dbo.Carts", name: "Product_Id", newName: "ProductId");
            RenameColumn(table: "dbo.OrderDetails", name: "Product_Id", newName: "ProductId");
            AlterColumn("dbo.Carts", "ProductId", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderDetails", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.Carts", "ProductId");
            CreateIndex("dbo.OrderDetails", "ProductId");
            AddForeignKey("dbo.Carts", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            DropColumn("dbo.Products", "ShoppingCart_Id");
            DropColumn("dbo.ShoppingCarts", "Total");
            DropColumn("dbo.ShoppingCarts", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ShoppingCarts", "User_Id", c => c.Int());
            AddColumn("dbo.ShoppingCarts", "Total", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "ShoppingCart_Id", c => c.Int());
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Carts", "ProductId", "dbo.Products");
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.Carts", new[] { "ProductId" });
            AlterColumn("dbo.OrderDetails", "ProductId", c => c.Int());
            AlterColumn("dbo.Carts", "ProductId", c => c.Int());
            RenameColumn(table: "dbo.OrderDetails", name: "ProductId", newName: "Product_Id");
            RenameColumn(table: "dbo.Carts", name: "ProductId", newName: "Product_Id");
            CreateIndex("dbo.ShoppingCarts", "User_Id");
            CreateIndex("dbo.OrderDetails", "Product_Id");
            CreateIndex("dbo.Products", "ShoppingCart_Id");
            CreateIndex("dbo.Carts", "Product_Id");
            AddForeignKey("dbo.OrderDetails", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.Carts", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.ShoppingCarts", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Products", "ShoppingCart_Id", "dbo.ShoppingCarts", "Id");
        }
    }
}
