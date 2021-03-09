namespace baitap2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khachhangs",
                c => new
                    {
                        Idkhachhang = c.String(nullable: false, maxLength: 128),
                        Tenkhachhang = c.String(),
                        Quequan = c.String(),
                        Tuoi = c.String(),
                    })
                .PrimaryKey(t => t.Idkhachhang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khachhangs");
        }
    }
}
