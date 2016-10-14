namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckPoint : DbMigration
    {
        public override void Up()
        {
            //CreateIndex("dbo.Product", "SupplierId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Product", new[] { "SupplierId" });
        }
    }
}
