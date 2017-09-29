namespace Kalafina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Album",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReleaseDate = c.DateTime(nullable: false),
                        ImageUrl = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Song",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TrackNo = c.Int(nullable: false),
                        AlbumID = c.Int(nullable: false),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Album", t => t.AlbumID, cascadeDelete: true)
                .Index(t => t.AlbumID);
            
            CreateTable(
                "dbo.ConcertList",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SongID = c.Int(nullable: false),
                        ConcertID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Concert", t => t.ConcertID, cascadeDelete: true)
                .ForeignKey("dbo.Song", t => t.SongID, cascadeDelete: true)
                .Index(t => t.SongID)
                .Index(t => t.ConcertID);
            
            CreateTable(
                "dbo.Concert",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Place = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConcertList", "SongID", "dbo.Song");
            DropForeignKey("dbo.ConcertList", "ConcertID", "dbo.Concert");
            DropForeignKey("dbo.Song", "AlbumID", "dbo.Album");
            DropIndex("dbo.ConcertList", new[] { "ConcertID" });
            DropIndex("dbo.ConcertList", new[] { "SongID" });
            DropIndex("dbo.Song", new[] { "AlbumID" });
            DropTable("dbo.Concert");
            DropTable("dbo.ConcertList");
            DropTable("dbo.Song");
            DropTable("dbo.Album");
        }
    }
}
