namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCustomerTableSchema2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.Customers", "FisrstName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "FisrstName", c => c.String());
            DropColumn("dbo.Customers", "FirstName");
        }
    }
}
