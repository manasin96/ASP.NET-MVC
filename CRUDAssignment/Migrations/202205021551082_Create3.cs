namespace CrudAssgmt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Name", c => c.String(nullable: false));
        }
    }
}
