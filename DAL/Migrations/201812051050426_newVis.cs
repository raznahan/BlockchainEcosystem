namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newVis : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Links", name: "source", newName: "From");
            RenameColumn(table: "dbo.Links", name: "target", newName: "To");
            RenameIndex(table: "dbo.Links", name: "IX_source", newName: "IX_From");
            RenameIndex(table: "dbo.Links", name: "IX_target", newName: "IX_To");
            AddColumn("dbo.Links", "Type", c => c.String());
            AddColumn("dbo.Links", "Title", c => c.String());
            AddColumn("dbo.Links", "Dashes", c => c.Boolean(nullable: false));
            AddColumn("dbo.Links", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Nodes", "Label", c => c.String());
            AddColumn("dbo.Nodes", "Link", c => c.String());
            AddColumn("dbo.Nodes", "Image", c => c.String());
            AddColumn("dbo.Nodes", "Description", c => c.String());
            AddColumn("dbo.Nodes", "Created", c => c.DateTime(nullable: false));
            DropColumn("dbo.Nodes", "name");
            DropColumn("dbo.Nodes", "val");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Nodes", "val", c => c.String());
            AddColumn("dbo.Nodes", "name", c => c.String());
            DropColumn("dbo.Nodes", "Created");
            DropColumn("dbo.Nodes", "Description");
            DropColumn("dbo.Nodes", "Image");
            DropColumn("dbo.Nodes", "Link");
            DropColumn("dbo.Nodes", "Label");
            DropColumn("dbo.Links", "Created");
            DropColumn("dbo.Links", "Dashes");
            DropColumn("dbo.Links", "Title");
            DropColumn("dbo.Links", "Type");
            RenameIndex(table: "dbo.Links", name: "IX_To", newName: "IX_target");
            RenameIndex(table: "dbo.Links", name: "IX_From", newName: "IX_source");
            RenameColumn(table: "dbo.Links", name: "To", newName: "target");
            RenameColumn(table: "dbo.Links", name: "From", newName: "source");
        }
    }
}
