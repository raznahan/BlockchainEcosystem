namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Links",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        source = c.Int(nullable: false),
                        target = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Nodes", t => t.source, cascadeDelete: false)
                .ForeignKey("dbo.Nodes", t => t.target, cascadeDelete: true)
                .Index(t => t.source)
                .Index(t => t.target);
            
            CreateTable(
                "dbo.Nodes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        val = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Links", "target", "dbo.Nodes");
            DropForeignKey("dbo.Links", "source", "dbo.Nodes");
            DropIndex("dbo.Links", new[] { "target" });
            DropIndex("dbo.Links", new[] { "source" });
            DropTable("dbo.Nodes");
            DropTable("dbo.Links");
        }
    }
}
