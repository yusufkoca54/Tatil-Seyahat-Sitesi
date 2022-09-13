namespace TatilSeyahatSitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteİletisimTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.İletisim");
        }
        
        public override void Down()
        {
            CreateTable("dbo.İletisim",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    AdSoyad = c.String(),
                    Mail = c.String(),
                    Konu = c.String(),
                    Mesaj = c.String(),

                })
               .PrimaryKey(t => t.Id);
        }
    }
}
