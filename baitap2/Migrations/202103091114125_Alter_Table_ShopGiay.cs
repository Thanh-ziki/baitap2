namespace baitap2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Table_ShopGiay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShopGiays", "SizeGiay", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShopGiays", "SizeGiay");
        }
    }
}
