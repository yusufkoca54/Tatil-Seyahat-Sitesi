namespace TatilSeyahatSitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateiletisimsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.iletisims",
                c => new
                    {
                        iletisimId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Sehir = c.String(),
                        Mail = c.String(),
                        Baslik = c.String(),
                        Mesaj = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.iletisimId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.iletisims");
        }
    }
}
