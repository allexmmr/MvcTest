using System.Data.Entity.Migrations;

namespace MvcTest.Data.Migrations
{
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contact",
                c => new
                {
                    Id = c.Int(nullable: false),
                    FirstName = c.String(),
                    LastName = c.String(),
                    Knickname = c.String(),
                    DisplayAs = c.Byte(nullable: false),
                    DateOfBirth = c.DateTime(nullable: true),
                    PhoneNumber = c.String()
                }).PrimaryKey(q => q.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Contact");
        }
    }
}