using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.netCoreMvcCrud.Migrations
{
    public partial class ColoumnsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    CompanyType = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    CompanyLimited = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Busineess = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Benifits = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ListProducts = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    TrustElements = table.Column<string>(type: "nvarchar(250)", maxLength: 100, nullable: false),
                    ImportantAreas = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    WebsiteExample = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
