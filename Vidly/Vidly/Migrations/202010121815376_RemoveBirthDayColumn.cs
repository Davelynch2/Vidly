namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveBirthDayColumn : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Customers DROP COLUMN BirthDate");
        }
        
        public override void Down()
        {
        }
    }
}
