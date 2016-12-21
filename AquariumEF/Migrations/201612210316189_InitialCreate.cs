namespace AquariumEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AquariumAquaticLives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Aquarium_Id = c.Int(nullable: false),
                        AquaticLife_Id = c.Int(),
                        Ocean_Id = c.Int(),
                        Aquarium_Id1 = c.Int(),
                        AquaticLife_Id1 = c.Int(),
                        Ocean_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aquaria", t => t.Aquarium_Id1)
                .ForeignKey("dbo.AquaticLives", t => t.AquaticLife_Id1)
                .ForeignKey("dbo.Oceans", t => t.Ocean_Id1)
                .Index(t => t.Aquarium_Id1)
                .Index(t => t.AquaticLife_Id1)
                .Index(t => t.Ocean_Id1);
            
            CreateTable(
                "dbo.Aquaria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AquaticLives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Name = c.String(),
                        Color = c.String(),
                        Length = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Oceans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AvgTemp = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AquariumAquaticLives", "Ocean_Id1", "dbo.Oceans");
            DropForeignKey("dbo.AquariumAquaticLives", "AquaticLife_Id1", "dbo.AquaticLives");
            DropForeignKey("dbo.AquariumAquaticLives", "Aquarium_Id1", "dbo.Aquaria");
            DropIndex("dbo.AquariumAquaticLives", new[] { "Ocean_Id1" });
            DropIndex("dbo.AquariumAquaticLives", new[] { "AquaticLife_Id1" });
            DropIndex("dbo.AquariumAquaticLives", new[] { "Aquarium_Id1" });
            DropTable("dbo.Oceans");
            DropTable("dbo.AquaticLives");
            DropTable("dbo.Aquaria");
            DropTable("dbo.AquariumAquaticLives");
        }
    }
}
