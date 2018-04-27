namespace EFApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCourseTitleMaxLength100 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Course", "Title", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Course", "Title", c => c.String());
        }
    }
}
