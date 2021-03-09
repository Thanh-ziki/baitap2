namespace baitap2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_SHopGiays : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShopGiays",
                c => new
                    {
                        IDKhachhang = c.String(nullable: false, maxLength: 128),
                        Tenkhachhang = c.String(),
                        IDGiay = c.String(),
                        LoaiGiay = c.String(),
                    })
                .PrimaryKey(t => t.IDKhachhang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShopGiays");
        }
    }
}
