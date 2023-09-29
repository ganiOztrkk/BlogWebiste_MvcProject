namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_Admin_Image : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "AdminImage");
        }
    }
}
