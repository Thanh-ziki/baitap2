namespace baitap2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ShopPets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShopPets",
                c => new
                    {
                        IDPet = c.String(nullable: false, maxLength: 128),
                        TenPet = c.String(),
                        LoaiPet = c.String(),
                        TuoiCuaPet = c.String(),
                    })
                .PrimaryKey(t => t.IDPet);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShopPets");
        }
    }
}
