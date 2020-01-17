namespace Icatu.EmployeeManagerAPI.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correct_department_size : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Department", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Department", c => c.String());
        }
    }
}
