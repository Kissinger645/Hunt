namespace GoatHunt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hunts", "Permits", c => c.String());
            AlterColumn("dbo.Hunts", "HuntersAfield", c => c.String());
            AlterColumn("dbo.Hunts", "Harvest", c => c.String());
            AlterColumn("dbo.Hunts", "AverageDays", c => c.String());
            AlterColumn("dbo.Hunts", "Success", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hunts", "Success", c => c.Double(nullable: false));
            AlterColumn("dbo.Hunts", "AverageDays", c => c.Double(nullable: false));
            AlterColumn("dbo.Hunts", "Harvest", c => c.Int(nullable: false));
            AlterColumn("dbo.Hunts", "HuntersAfield", c => c.Int(nullable: false));
            AlterColumn("dbo.Hunts", "Permits", c => c.Int(nullable: false));
        }
    }
}
