using Microsoft.EntityFrameworkCore.Migrations;

namespace DBMigrationV1.Migrations
{
    public partial class InsertEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Insert into Employee
(Id,Name,Email,MobilePhone,AnnualBalance,SickBalance)
Values
(1,'Passant Ibrahim','passantibrahim96@gmail.com','01159455077',21,6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Delete from Employee where id=1");
        }
    }
}
