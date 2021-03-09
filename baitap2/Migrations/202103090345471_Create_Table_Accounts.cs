namespace baitap2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Accounts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Acconuts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128, fixedLength: true, unicode: false),
                        Passwork = c.String(),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Acconuts");
        }
    }
}
